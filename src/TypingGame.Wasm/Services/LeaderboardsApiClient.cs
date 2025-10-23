using System.Net.Http.Json;
using TypingGame.Core.DTO;
using TypingGame.Core.Services;

public class LeaderboardsApiClient : ILeaderboardAPI {
    private readonly HttpClient _http;

    public LeaderboardsApiClient(HttpClient http) => _http = http;

    
    public async Task<LeaderboardEntryDTO> SubmitEntryAsync(LeaderboardEntryDTO entry, CancellationToken token = default) {
        if (entry.Timestamp.Kind == DateTimeKind.Unspecified)
            entry.Timestamp = DateTime.SpecifyKind(entry.Timestamp, DateTimeKind.Utc);

        var resp = await _http.PostAsJsonAsync("api/leaderboards", entry, token);
        if (resp.IsSuccessStatusCode)
            return await resp.Content.ReadFromJsonAsync<LeaderboardEntryDTO>(cancellationToken: token);

        var body = await resp.Content.ReadAsStringAsync(token);
        throw new HttpRequestException($"Submit failed ({(int)resp.StatusCode}): {body}");
    }

    public async Task<IReadOnlyList<LeaderboardEntryDTO>> GetEntriesByCategoryAsync(string category, int limit = 50, CancellationToken token = default) {
        var path = $"api/leaderboards/{Uri.EscapeDataString(category)}?limit={limit}";
        var list = await _http.GetFromJsonAsync<List<LeaderboardEntryDTO>>(path, cancellationToken: token);
        return list ?? new();
    }

    public Task<string> CosmosPingAsync(CancellationToken token = default)
        => _http.GetStringAsync("api/cosmos-ping", token);
}
