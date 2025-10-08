namespace TypingGame.DataModels
{
    // Holds all of the user-selectable phrase categories
    public enum Category { General, CSharp, SingleWords }
    
    // Holds all of the game configuration settings; only set once at the start of the game
    // Default GameDurationSeconds to 60; this is here in case I want to implement user-selected test duration later on
    public record GameConfig(string PlayerName, Category Category, bool BlindMode, int GameDurationSeconds = 60);
}
