using TypingGame.Core.DTO;

namespace TypingGame.Core.Engine {
    public interface IGameEngine {
        public GameUpdateDTO InitializeGame(IReadOnlyList<string> phraseList, GameConfig config);
        public GameUpdateDTO SubmitEvent(PhraseSubmissionDTO submission);
        public GameSummary Results(int playerID = 1);
    }
}
