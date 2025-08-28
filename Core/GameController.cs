using System.Diagnostics;
using TypingGame.DataModels;

namespace TypingGame.Core
{
    // GameSession holds all of the relevant information for the current game session (in WPMGameplayControl)
    public class GameController
    {
        private readonly Stopwatch gameTimer;
        private string[] wordLabels = new string[5];
        PhraseHandler phraseHandler;
        public GameConfig Config { get; }
        string CurrentWord { get; set; }
        int TotalChars { get; set; } // total characters throughout entire game session
        int TotalErrors { get; set; } // total errors throughout entire game session
        int SubmissionCount { get; set; } // total phrases completed throughout entire game session
        public bool IsPaused { get; set; }
        double RemainingTime { get; set; }

        public GameController(GameConfig config)
        {
            Config = config;
            CurrentWord = null;
            TotalChars = 0;
            TotalErrors = 0;
            SubmissionCount = 0;
            IsPaused = true; // unpause after player starts typing

            gameTimer = new Stopwatch();
            phraseHandler = new PhraseHandler(config.Category);
        }

        public void InitializeRun()
        {
            // Set word labels
            for (int i = 0; i < wordLabels.Length; i++)
                wordLabels[i] = phraseHandler.Next();

            // Set CurrentWord to first label
            CurrentWord = wordLabels[0];
        }

        public HUD GetHUD()
        {
            //computes TimeRemaining, NetWPM, AccuracyPercent
            double elapsedSeconds = gameTimer.Elapsed.TotalSeconds;
            double timeRemainingSeconds = Config.GameDurationSeconds - elapsedSeconds;
            double grossWPM = MetricsCalculator.GrossWPM(TotalChars, SubmissionCount, elapsedSeconds);
            double accuracyPercent = MetricsCalculator.Accuracy(TotalChars, TotalErrors);
            HUD hud = new(timeRemainingSeconds, grossWPM, accuracyPercent);

            return hud;
        }

        public bool Submit(string input)
        {
            // In case game is paused for whatever reason, return
            if (IsPaused) return false;

            // Trim word to remove whitespace from before/after input (we will not penalize players for this)
            input = input.Trim();
            
            // Set CurrentWord to variable due to calling NextWord(); before return
            string word = CurrentWord;

            // Update TotalChars and add one to SubmissionCount
            TotalChars += word.Length;
            SubmissionCount++;

            // Only count errors if input and CurrentWord are different, otherwise skip to increase performance
            if (input != word)
            {
                // Count number of errors in submission
                int phraseErrors = MetricsCalculator.CountErrors(input, word);

                // Update TotalErrors
                TotalErrors += phraseErrors;
            }

            // Get next word and update wordLabels
            NextWord();

            // Return true/false
            return input == word;
        }

        void NextWord()
        {
            // Except for the last element, move words "forward"
            for (int i = 0; i < wordLabels.Length - 1; i++)
            {
                wordLabels[i] = wordLabels[i + 1];
            }

            // Get new word for last element
            wordLabels[wordLabels.Length - 1] = phraseHandler.Next();

            // Set CurrentWord to first label
            CurrentWord = wordLabels[0];
        }

        public void Pause()
        {
            IsPaused = true;
            gameTimer.Stop();
        }

        public void Resume()
        {
            IsPaused = false;
            gameTimer.Start();
        }

        public GameSummary EndRun()
        {
            // Stop run
            Pause();

            // Calculate final WPM and accuracy
            double finalGrossWPM = MetricsCalculator.GrossWPM(TotalChars, SubmissionCount, Config.GameDurationSeconds);
            double finalNetWPM = MetricsCalculator.NetWPM(TotalChars, TotalErrors, SubmissionCount, Config.GameDurationSeconds);
            double finalAccuracy = MetricsCalculator.Accuracy(TotalChars, TotalErrors);

            // Create GameSummary record
            GameSummary gameSummary = new GameSummary(
                PlayerName: Config.PlayerName,
                Category: Config.Category,
                BlindMode: Config.BlindMode,
                GameDurationSeconds: Config.GameDurationSeconds,
                TotalSubmissions: SubmissionCount,
                TotalChars: TotalChars,
                TotalErrors: TotalErrors,
                FinalGrossWPM: finalGrossWPM,
                FinalNetWPM: finalNetWPM,
                FinalAccuracy: finalAccuracy,
                Timestamp: DateTime.UtcNow
            );

            return gameSummary;
        }

        public IReadOnlyCollection<string> GetWordLabels()
        {
            //return wordLabels.AsReadOnly();
            return Array.AsReadOnly(wordLabels);
        }
    }
}
