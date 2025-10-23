using TypingGame.Core.DTO;
using TypingGame.Core.Models;
using TypingGame.Core.Services;

namespace TypingGame.Core.Engine {
    // GameEngine holds all of the relevant information for the current game session (in WPMGameplayControl)
    public class GameEngine : IGameEngine {
        private readonly IPhraseService _phraseService;
        GameConfigDTO Config { get; set; }
        PlayerStats? CurrentPlayer { get; set; }
        PlayerStats? Player1 { get; set; }
        PlayerStats? Player2 { get; set; }

        public GameEngine(IPhraseService phraseService) {
            _phraseService = phraseService;
        }

        public GameUpdateDTO InitializeGame(IReadOnlyList<string> phraseList, GameConfigDTO config) {
            // Initialize phrases            
            _phraseService.InitializePhrases(phraseList);

            // Set config to property to send with GameSummary
            Config = config;

            // Return a blank GameUpdateDTO (except for first 5 phrases) to update HUD
            return new GameUpdateDTO(0, 0, null, _phraseService.PhraseArray);
        }

        private void SetCurrentPlayer(int playerID) {
            // If submission is from player 1: set object for Player 1
            if (playerID == 1) {
                if (Player1 == null) {
                    Player1 = new PlayerStats(1);
                }

                CurrentPlayer = Player1;
            }

            // If submission is from player 2: set object for Player 2
            if (playerID == 2) {
                if (Player2 == null) {
                    Player2 = new PlayerStats(2);
                }

                CurrentPlayer = Player2;
            }
        }

        public GameUpdateDTO SubmitEvent(PhraseSubmissionDTO submission) {
            // Set current player object
            SetCurrentPlayer(submission.playerID);

            // Calculate values required for GameUpdateDTO
            // SubmitPhrase needs to be called first to accurately set TotalChars/TotalErrors/TotalSubmissions properties
            bool isPhraseCorrect = SubmitPhrase(submission.userInput, submission.currentPhrase);
            double grossWPM = MetricsService.GrossWPM(CurrentPlayer.TotalChars, CurrentPlayer.TotalSubmissions, submission.elapsedTimeInSeconds);
            double accuracyPercent = MetricsService.Accuracy(CurrentPlayer.TotalChars, CurrentPlayer.TotalErrors);
            _phraseService.Next();

            // Create GameUpdateDTO and return it
            var updateDTO = new GameUpdateDTO(
                grossWPM,
                accuracyPercent,
                isPhraseCorrect,
                _phraseService.PhraseArray
                );

            return updateDTO;
        }

        private bool SubmitPhrase(string userInput, string currentPhrase) {
            // Trim phrase to remove leading/trailing whitespace (no penalization for this)
            userInput = userInput.Trim();

            // Bookkeeping for TotalChars and TotalSubmissions in PlayerStats
            CurrentPlayer.TotalChars += currentPhrase.Length;
            CurrentPlayer.TotalSubmissions++;

            // If userInput and currentPhrase are different, calculate errors; otherwise, skip to increase performance
            if (userInput != currentPhrase) {
                // Count number of errors in submission
                int phraseErrors = MetricsService.CountErrors(userInput, currentPhrase);

                // Bookkeeping for TotalErrors in PlayerStats
                CurrentPlayer.TotalErrors += phraseErrors;
            }

            return userInput == currentPhrase;
        }

        public GameSummaryDTO Results(int playerID = 1) {
            // Set current player object
            SetCurrentPlayer(playerID);

            // Create GameSummary and return it        
            var gameSummary = new GameSummaryDTO(
                Stats: CurrentPlayer,
                Config: Config,
                FinalGrossWPM: MetricsService.GrossWPM(CurrentPlayer.TotalChars, CurrentPlayer.TotalSubmissions, Config.GameDurationSeconds),
                FinalNetWPM: MetricsService.NetWPM(CurrentPlayer.TotalChars, CurrentPlayer.TotalErrors, CurrentPlayer.TotalSubmissions, Config.GameDurationSeconds),
                FinalAccuracy: MetricsService.Accuracy(CurrentPlayer.TotalChars, CurrentPlayer.TotalErrors),
                Timestamp: DateTime.UtcNow
                );

            return gameSummary;
        }
    }
}
