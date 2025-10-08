using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame.DataModels
{
    // Data Model holds all of the information to be shown on the Results screen
    public record GameSummary (string PlayerName, Category Category, bool BlindMode, int GameDurationSeconds, int TotalSubmissions, int TotalChars, int TotalErrors, double FinalGrossWPM, double FinalNetWPM, double FinalAccuracy, DateTime Timestamp);
}
