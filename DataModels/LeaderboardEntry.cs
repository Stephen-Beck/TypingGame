using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame.DataModels
{
    // LeaderboardEntry creates a record for the Leaderboard
    public record LeaderboardEntry(string PlayerName, double FinalGrossWPM, double FinalNetWPM, double FinalAccuracy, DateTime Timestamp);
}
