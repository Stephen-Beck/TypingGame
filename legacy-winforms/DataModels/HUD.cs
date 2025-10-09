using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame.DataModels
{
    public class HUD
    {
        // Holds the values to be pushed to the HUD labels
        public double TimeRemaining { get; set; }
        public double GrossWPM { get; set; }
        public double AccuracyPercent { get; set; }

        public HUD(double timeRemaining, double grossWPM, double accuracyPercent)
        {
            TimeRemaining = timeRemaining;
            GrossWPM = grossWPM;
            AccuracyPercent = accuracyPercent;
        }
    }
}
