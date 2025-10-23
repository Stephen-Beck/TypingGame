using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TypingGame.Core.Models;

namespace TypingGame.Core.DTO
{
    // Holds all of the game configuration settings; only set once at the start of the game
    // Default GameDurationSeconds to 60; this is here in case I want to implement user-selected test duration later on
    public record GameConfigDTO(Category Category, bool BlindInputMode, int GameDurationSeconds = 60);
}
