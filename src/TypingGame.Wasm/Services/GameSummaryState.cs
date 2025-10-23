using TypingGame.Core.DTO;

namespace TypingGame.Wasm.Services {
    public class GameSummaryState {
        // Small state container to hold the GameSummaryDTO while navigating to the leaderboards
        public GameSummaryDTO? GameSummary { get; private set; }
        public void Set(GameSummaryDTO summary) => GameSummary = summary;
        public void Clear() => GameSummary = null;
    }
}