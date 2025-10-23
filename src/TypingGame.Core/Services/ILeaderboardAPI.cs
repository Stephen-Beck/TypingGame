using TypingGame.Core.DTO;

namespace TypingGame.Core.Services {
    public interface ILeaderboardAPI {
        Task<LeaderboardEntryDTO> SubmitEntryAsync(LeaderboardEntryDTO entry, CancellationToken token = default);
        Task<IReadOnlyList<LeaderboardEntryDTO>> GetEntriesByCategoryAsync(string category, int limit = 50, CancellationToken token = default);
        Task<string> CosmosPingAsync(CancellationToken token = default);
    }
}
