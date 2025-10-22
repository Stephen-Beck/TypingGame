namespace TypingGame.Core.Services {
    public class PhraseService : IPhraseService {
        private string[] originalList; // Note: the order of the original list is NOT preserved due to Shuffle(), but the contents are not changed
        private Queue<string> phraseQueue;
        public string[] PhraseArray { get; private set; }
        public void InitializePhrases(IReadOnlyList<string> phraseList) {
            if (originalList == null) originalList = phraseList.ToArray(); // Only assign originalList the first time InitializePhrases() is called

            FillQueue();
            PhraseArray = new string[5];

            // initialize PhraseArray
            for (int i = 0; i < 5; i++) {
                //PhraseArray[i] = phraseQueue.Dequeue();
                Next();
            }
        }

        private void FillQueue() {
            phraseQueue = new Queue<string>(Shuffle(originalList));
        }

        private string[] Shuffle(string[] phrases) {
            Random random = Random.Shared;

            // Fisher-Yates shuffle      
            for (int i = phrases.Length - 1; i > 0; i--) {
                int j = random.Next(0, i + 1);

                string temp = phrases[i];
                phrases[i] = phrases[j];
                phrases[j] = temp;
            }

            return phrases;
        }
        private bool IsEmpty() {
            return phraseQueue.Count == 0;
        }
        public void Next() {
            // If Queue is empty, refill it
            if (IsEmpty()) FillQueue();

            // Shift phrase array and add next word to the end
            PhraseArray.AsSpan(1).CopyTo(PhraseArray); // Elements 2-5 become Elements 1-4
            PhraseArray[^1] = phraseQueue.Dequeue(); // Last index comes from queue; [^1] = last index, allowing for changing the array size later without needing to fix hardcoding here
        }
    }
}
