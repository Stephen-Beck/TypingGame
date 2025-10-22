using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingGame.Core.Models;

namespace TypingGame.Core.DTO
{
    // Data Model holds all of the information to be shown on the Results screen
    public record GameSummary(
        PlayerStats Stats, 
        GameConfig Config, 
        double FinalGrossWPM, 
        double FinalNetWPM, 
        double FinalAccuracy, 
        DateTime Timestamp
        );
}
