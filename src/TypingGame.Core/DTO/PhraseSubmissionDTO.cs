using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame.Core.DTO {
    public record PhraseSubmissionDTO(string userInput, string currentPhrase, double elapsedTimeInSeconds, int playerID=1);

    // This DTO is used when a player submits their entry (Game -> Core)

    // SubmittedPhrase: Self-explanatory; the phrase as-written that was submitted by the player
    // CurrentPhrase: Self-explanatory; the correct phrase to be compared against the SubmittedPhrase. This seems like the easiest way to separate different players being on different phrases
    // ElapsedTimeInSeconds: Total time elapsed in the game (in seconds)
    // PlayerID: 1 for singleplayer or multiplayer host, 2 for second player (can add to this later if I expand past two players)
}
