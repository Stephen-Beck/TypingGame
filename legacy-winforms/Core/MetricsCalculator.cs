namespace TypingGame.Core
{
    // Metrics handles all of the calculations
    public static class MetricsCalculator
    {
        public static double NetWPM(int totalChars, int totalErrors, int submissions, double elapsedSeconds)
        {
            if (elapsedSeconds == 0) return 0;
            return (totalChars + submissions - totalErrors) / 5 / (elapsedSeconds / 60);
        }

        public static double GrossWPM(int totalChars, int submissions, double elapsedSeconds)
        {
            if (elapsedSeconds == 0) return 0;
            return (totalChars + submissions) / 5 / (elapsedSeconds / 60);
        }

        public static int CountErrors(string input, string phrase)
        {
            /*
            Implements the Levenshtein distance algorithm; metric for measuring the difference between two strings
            https://en.wikipedia.org/wiki/Levenshtein_distance

            It compares two strings and counts how many "edits" (insert, delete, substitute) it would take to change one string into the other.
            */

            // Make 2D array where each cell represents the minimum number of edits needed up to that point
            int[,] compare = new int[input.Length + 1, phrase.Length + 1];

            for (int i = 0; i <= input.Length; i++) compare[i, 0] = i; // Fill the first column (it takes 'i' deletions to turn the first 'i' letters of 'input' into an empty string
            for (int j = 0; j <= phrase.Length; j++) compare[0, j] = j; // Fill the first row (it takes 'j' insertions to turn an empty string into the first 'j' letters of 'phrase'

            // Iteration through each letter of both phrases
            for (int i = 1; i <= input.Length; i++)
            {
                for (int j = 1; j <= phrase.Length; j++)
                {
                    // If the characters are the same, cost = 0, else cost = 1
                    int cost = (input[i - 1] == phrase[j - 1]) ? 0 : 1;

                    // Choose the "cheapest" option
                    compare[i, j] = Math.Min(Math.Min(
                        compare[i - 1, j] + 1,          // Deletion
                        compare[i, j - 1] + 1),         // Insertion
                        compare[i - 1, j - 1] + cost);  // Substitution
                }
            }

            // The last cell contains the minimum edits necessary to change the full input into the full phrase
            return compare[input.Length, phrase.Length];
        }

        public static double Accuracy(int totalChars, int totalErrors)
        {
            if (totalChars == 0) return 0;
            return 1 - ((double)totalErrors / totalChars);
        }
    }
}