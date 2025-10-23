using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Text.Json;
using TypingGame.Core.DTO;

namespace LeaderboardsAPI {
    public class LeaderboardsAPI {
        private static readonly JsonSerializerOptions options = new(JsonSerializerDefaults.Web);
        private readonly Container _container;

        public LeaderboardsAPI(IConfiguration config) {
            // read from settings; fall back to your known names
            var connString = config["COSMOS_CONN_STR"] ?? throw new InvalidOperationException("COSMOS_CONN_STR not set");
            var dbName = config["COSMOS_DB_NAME"] ?? "typing-game-cosmosdb";
            var containerName = config["COSMOS_CONTAINER_NAME"] ?? "leaderboards";

            var client = new CosmosClient(connString, new CosmosClientOptions { ConnectionMode = ConnectionMode.Gateway });
            _container = client.GetContainer(dbName, containerName);
        }

        // POST /api/leaderboards
        // example body: { "Category":"General","Name":"Alex","NetWPM":55,"Accuracy":0.97,"GrossWPM":60,"Timestamp":"2025-01-01T00:00:00Z" }
        [Function("CreateLeaderboardEntry")]
        public async Task<HttpResponseData> SubmitEntry(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "leaderboards")] HttpRequestData request) {
            
            // Deserialize the request JSON into a LeaderboardEntryDTO
            LeaderboardEntryDTO? entry = await JsonSerializer.DeserializeAsync<LeaderboardEntryDTO>(request.Body, options);

            // Validate required fields; if something is missing, mention it
            if (entry is null || string.IsNullOrWhiteSpace(entry.Category) || string.IsNullOrWhiteSpace(entry.Name)) {
                var badRequest = request.CreateResponse(HttpStatusCode.BadRequest);
                await badRequest.WriteStringAsync("Invalid body. Require Category, Name, NetWPM, Accuracy, GrossWPM, Timestamp.");
                return badRequest;
            }

            // Ensure the entry has an id for CosmosDB and generate one if it doesn't exist
            entry.id ??= Guid.NewGuid().ToString();

            // If the timestamp is unspecified, it assumes it is UTC
            if (entry.Timestamp.Kind == DateTimeKind.Unspecified)
                entry.Timestamp = DateTime.SpecifyKind(entry.Timestamp, DateTimeKind.Utc);

            // Attempt to create the item in CosmosDB; throw errors given by CosmosDB if it failed
            try {
                // Create item in DB
                var created = await _container.CreateItemAsync(entry, new PartitionKey(entry.Category));
                
                // Create a "created" HTTP response and add header to it
                var response = request.CreateResponse(HttpStatusCode.Created);
                response.Headers.Add("Content-Type", "application/json; charset=utf-8");
                
                // Serialize the created resource and return it
                await response.WriteStringAsync(JsonSerializer.Serialize(created.Resource, options));
                return response;
            }
            catch (CosmosException ex) {
                var errorResponse = request.CreateResponse((HttpStatusCode)ex.StatusCode);
                var errorDetails = new {
                    message = ex.Message,
                    status = ex.StatusCode,
                    substatus = ex.SubStatusCode,
                    activityId = ex.ActivityId
                };
                await errorResponse.WriteStringAsync(JsonSerializer.Serialize(errorDetails, options));
                return errorResponse;
            }

        }

        // GET /api/leaderboards/{category}
        [Function("GetLeaderboardByCategory")]
        public async Task<HttpResponseData> GetEntriesByCategory(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "leaderboards/{category}")] HttpRequestData request,
    string category) {
            
            // Server-side sort and trim (top 50) inside the partition
            var query = new QueryDefinition(@"
        SELECT TOP 50 *
        FROM c
        WHERE c.Category = @cat
        ORDER BY c.NetWPM DESC, c.Accuracy DESC, c.GrossWPM DESC, c.Timestamp ASC")
                .WithParameter("@cat", category); // Bind the @cat parameter to the requested category

            var entries = new List<LeaderboardEntryDTO>();

            try {
                // Iterate through all of the returned entries and add them to the entries list
                using var iterator = _container.GetItemQueryIterator<LeaderboardEntryDTO>(
                    query,
                    requestOptions: new QueryRequestOptions { PartitionKey = new PartitionKey(category) });

                // Iterate through iterator pages until we have 50 entries
                while (iterator.HasMoreResults && entries.Count < 50) {
                    var page = await iterator.ReadNextAsync();
                    entries.AddRange(page);
                }
            }
            catch (CosmosException ex) {
                var errorResponse = request.CreateResponse((HttpStatusCode)ex.StatusCode);
                var errorDetails = new { message = ex.Message, status = ex.StatusCode, substatus = ex.SubStatusCode, activityId = ex.ActivityId };
                await errorResponse.WriteStringAsync(JsonSerializer.Serialize(errorDetails, options));
                return errorResponse;
            }

            // Create a response with the results (entries list)
            var response = request.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");
            
            // Serialize the list of entries to the response body and return it
            await response.WriteStringAsync(JsonSerializer.Serialize(entries, options));
            return response;
        }

        // GET /api/cosmos-ping
        // Ping CosmosDB
        [Function("CosmosPing")]
        public async Task<HttpResponseData> CosmosPing(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "cosmos-ping")] HttpRequestData request) {
            try {
                var containerProperties = await _container.ReadContainerAsync();
                var response = request.CreateResponse(HttpStatusCode.OK);
                await response.WriteStringAsync($"OK: {containerProperties.Resource.Id}");
                return response;
            }
            catch (CosmosException ex) {
                var errorResponse = request.CreateResponse((HttpStatusCode)ex.StatusCode);
                await errorResponse.WriteStringAsync($"Cosmos error {ex.StatusCode}, sub {ex.SubStatusCode}, act {ex.ActivityId}: {ex.Message}");
                return errorResponse;
            }
        }

        // GET /api/ping
        // Ping API
        [Function("Ping")]
        public static async Task<HttpResponseData> Ping(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "ping")] HttpRequestData request) {
            var response = request.CreateResponse(HttpStatusCode.OK);
            await response.WriteStringAsync("pong");
            return response;
        }
    }
}