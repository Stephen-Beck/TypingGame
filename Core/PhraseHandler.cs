using TypingGame.DataModels;

namespace TypingGame.Core
{
    // PhraseHandler loads phrases from the respective phrase file, shuffles them, then passes them to the GameSession as needed
    public class PhraseHandler
    {
        Category Category { get; set; }
        Queue<string> PhraseQueue { get; set; }

        public PhraseHandler(Category category)
        {
            Category = category;
            Load(); // immediately fill phrases based on category
        }

        private void Load()
        {
            //set fileDirectory
            string fileDirectory = AppDomain.CurrentDomain.BaseDirectory;

            //set fileName based on category
            string fileName = $"Phrases_{Category}.txt";

            //create filePath
            string filePath = Path.Combine(fileDirectory, "Phrases", fileName);


            //load phrases from file into List<string>
            List<string> phrases = new();


            try //try-catch incase file does not exist
            {
                using (StreamReader reader = new(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!String.IsNullOrWhiteSpace(line))
                            phrases.Add(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "File Not Found!", MessageBoxButtons.OK);
                return;
            }

            Shuffle(phrases);
            PhraseQueue = new Queue<string>(phrases);
        }

        private void Shuffle(List<string> phrases)
        {
            //
            Random random = new Random();

            for (int i = phrases.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                string temp = phrases[i];
                phrases[i] = phrases[j];
                phrases[j] = temp;
            }
        }

        private bool IsEmpty()
        {
            return PhraseQueue.Count == 0;
        }

        public string Next()
        {
            // if queue is empty, reload it
            if (IsEmpty())
                Load();

            return PhraseQueue.Dequeue();
        }
    }
}
