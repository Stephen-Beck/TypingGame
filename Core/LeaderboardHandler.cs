using System.ComponentModel;
using System.Text.Json;
using TypingGame.DataModels;

namespace TypingGame.Core
{
    // LeaderboardHandler imports, adds, re-sorts, and exports leaderboard entries
    public class LeaderboardHandler
    {
        int numEntries = 20;
        string filePath;
        GameSummary Summary { get; }
        public Leaderboard Leaderboard { get; private set; }

        public LeaderboardHandler(GameSummary summary)
        {
            Summary = summary;
            Leaderboard = new(summary.Category, summary.BlindMode);
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Leaderboards", $"Leaderboards_{Leaderboard.GameType}.json");
            LoadFromJSON();
        }

        public List<LeaderboardEntry> LoadFromJSON()
        {
            // if file does not exist or is empty, create/save file
            // if Leaderboard contains no entries, it will populate the .json with just the header, which is fine
            if (!File.Exists(filePath)) SaveToJSON();

            string json = File.ReadAllText(filePath);
            if (String.IsNullOrWhiteSpace(json))
            {
                SaveToJSON();
                
                // read file again since formatting was fixed
                json = File.ReadAllText(filePath);
            }

            // after reading file, deserialize to Leaderboard object
            Leaderboard = JsonSerializer.Deserialize<Leaderboard>(json);

            return Leaderboard.Entries;
        }

        public void AddEntry(GameSummary summary)
        {
            // Create LeaderboardEntry
            LeaderboardEntry entry = new(
                PlayerName: summary.PlayerName,
                FinalGrossWPM: summary.FinalGrossWPM,
                FinalNetWPM: summary.FinalNetWPM,
                FinalAccuracy: summary.FinalAccuracy,
                Timestamp: summary.Timestamp
                );

            // Add entry to Leaderboard
            Leaderboard.Entries.Add(entry);

            // Sort Leaderboard entries and save to file
            Sort();
            SaveToJSON();
        }

        private void Sort()
        {
            // Sort descending (most to least) by NetWPM, then Accuracy, then GrossWPM, then (ascending by) Timestamp
            Leaderboard.Entries = Leaderboard.Entries
                .OrderByDescending(entry => entry.FinalNetWPM)
                .ThenByDescending(entry => entry.FinalAccuracy)
                .ThenByDescending(entry => entry.FinalGrossWPM)
                .ThenBy(entry => entry.Timestamp)
                .Take(numEntries).ToList(); //after sorting, push only the top (numEntries) entries to list
        }

        private void SaveToJSON()
        {
            //write to a temp file in case something happens during writing
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(Leaderboard, options);
            var tempPath = filePath + ".tmp";
            File.WriteAllText(tempPath, json);

            // Replace original file
            if (File.Exists(filePath)) File.Delete(filePath);
            File.Move(tempPath, filePath);
        }
    }
}
