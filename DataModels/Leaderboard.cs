using System.ComponentModel;

namespace TypingGame.DataModels
{
    public class Leaderboard
    {
        public string GameType { get; set; }
        public DateTime LastModified { get; set; }
        public List<LeaderboardEntry> Entries { get; set; }
        

        public Leaderboard(Category category, bool blindMode)
        {
            GameType = category + (blindMode ? "_BlindMode" : "");
            LastModified = DateTime.UtcNow;
            Entries = new();
        }

        public Leaderboard() { } // parameterless constructor for System.Text.Json
    }
}
