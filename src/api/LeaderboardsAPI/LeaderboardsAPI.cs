using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Text.Json;
using TypingGame.Core.DTO;

namespace LeaderboardsAPI {
    public class LeaderboardsAPI {
        private static readonly JsonSerializerOptions JsonOpts = new(JsonSerializerDefaults.Web);
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
            LeaderboardEntryDTO? entry = await JsonSerializer.DeserializeAsync<LeaderboardEntryDTO>(request.Body, JsonOpts);
            if (entry is null || string.IsNullOrWhiteSpace(entry.Category) || string.IsNullOrWhiteSpace(entry.Name)) {
                var badRequest = request.CreateResponse(HttpStatusCode.BadRequest);
                await badRequest.WriteStringAsync("Invalid body. Require Category, Name, NetWPM, Accuracy, GrossWPM, Timestamp.");
                return badRequest;
            }

            // ensure Cosmos-required bits
            entry.id ??= Guid.NewGuid().ToString();
            if (entry.Timestamp.Kind == DateTimeKind.Unspecified)
                entry.Timestamp = DateTime.SpecifyKind(entry.Timestamp, DateTimeKind.Utc);

            // POST create
            try {
                var created = await _container.CreateItemAsync(entry, new PartitionKey(entry.Category));
                var response = request.CreateResponse(HttpStatusCode.Created);
                response.Headers.Add("Content-Type", "application/json; charset=utf-8");
                await response.WriteStringAsync(JsonSerializer.Serialize(created.Resource, JsonOpts));
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
                await errorResponse.WriteStringAsync(JsonSerializer.Serialize(errorDetails, JsonOpts));
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
                .WithParameter("@cat", category);

            var entries = new List<LeaderboardEntryDTO>();

            try {
                using var iterator = _container.GetItemQueryIterator<LeaderboardEntryDTO>(
                    query,
                    requestOptions: new QueryRequestOptions { PartitionKey = new PartitionKey(category) });

                while (iterator.HasMoreResults && entries.Count < 50) {
                    var page = await iterator.ReadNextAsync();
                    entries.AddRange(page);

                    // If a single page already satisfied TOP 50, we’ll exit on the loop condition.
                }
            }
            catch (CosmosException ex) {
                var errorResponse = request.CreateResponse((HttpStatusCode)ex.StatusCode);
                var errorDetails = new { message = ex.Message, status = ex.StatusCode, substatus = ex.SubStatusCode, activityId = ex.ActivityId };
                await errorResponse.WriteStringAsync(JsonSerializer.Serialize(errorDetails, JsonOpts));
                return errorResponse;
            }

            var response = request.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");
            await response.WriteStringAsync(JsonSerializer.Serialize(entries, JsonOpts));
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