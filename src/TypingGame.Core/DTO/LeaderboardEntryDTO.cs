using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TypingGame.Core.DTO {
    // LeaderboardEntry creates a record for the Leaderboard
    public class LeaderboardEntryDTO {

        [JsonRequired, JsonPropertyName("Category")]
        public string Category { get; set; } // Partition key

        [JsonRequired, JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonRequired, JsonPropertyName("NetWPM")]
        [Range(0, double.MaxValue)] // Requires a positive integer
        public double NetWPM { get; set; }

        [JsonRequired, JsonPropertyName("Accuracy")]
        [Range(0.0, 1.0)] // Requires value clamped between 0-1 (0-100%)
        public double Accuracy { get; set; }

        [JsonRequired, JsonPropertyName("GrossWPM")]
        [Range(0, double.MaxValue)] // Request a positive integer
        public double GrossWPM { get; set; }

        [JsonRequired, JsonPropertyName("Timestamp")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public string? id { get; set; }
    }
}
