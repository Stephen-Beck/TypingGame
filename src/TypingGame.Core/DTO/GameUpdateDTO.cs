using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame.Core.DTO {
    public record GameUpdateDTO(double GrossWPM, double AccuracyPercent, bool? IsPhraseCorrect, string[] NextPhrases, int PlayerID = 1);

    // This DTO is used in response to a player's submission to update the HUD (Core -> Game)

    // GrossWPM: WPM to display on HUD
    // AccuracyPercent: Accuracy to display on HUD (sent as double, so 0.991 == 99.1%)
    // IsPhraseCorrect: Is submitted phrase correct (true) or were there errors (false)?
    // NextPhrases: String of five phrases to fill in labels on UI. This will allow separate phrases for multiplayer and keep a clearer separation between UI and logic
    // PlayerID: 1 for singleplayer or multiplayer host, 2 for second player (can add to this later if I expand past two players)
}
