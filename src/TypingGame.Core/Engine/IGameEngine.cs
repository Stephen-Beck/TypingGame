using TypingGame.Core.DTO;

namespace TypingGame.Core.Engine {
    public interface IGameEngine {
        public GameUpdateDTO InitializeGame(IReadOnlyList<string> phraseList, GameConfigDTO config);
        public GameUpdateDTO SubmitEvent(PhraseSubmissionDTO submission);
        public GameSummaryDTO Results(int playerID = 1);
    }
}
