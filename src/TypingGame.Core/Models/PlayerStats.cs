using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame.Core.Models {
    public class PlayerStats {
        public int PlayerID { get; }
        public int TotalChars { get; set; } // total characters of given phrases (not user input!) throughout entire game session
        public int TotalErrors { get; set; } // total errors throughout entire game session
        public int TotalSubmissions { get; set; } // total phrases completed throughout entire game session

        public PlayerStats(int playerID) {
            PlayerID = playerID;
        }
    }
}
