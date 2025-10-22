namespace TypingGame.Core.Services {
    public interface IPhraseService {
        string[] PhraseArray { get; }
        void InitializePhrases(IReadOnlyList<string> phraseList);
        void Next();
    }
}
