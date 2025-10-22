using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame.Core.DTO
{
    // Holds all of the user-selectable phrase categories
    public enum Category { 
        [Description("General")] General, 
        [Description("C#")] CSharp, 
        [Description("Single Words")] SingleWords
    }

    // Adds a .GetDescription() helper method
    public static class EnumExtensions {
        public static string GetDescription(this Enum enumValue) {
            FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());

            if (field != null) {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0) {
                    return attributes[0].Description;
                }
            }

            // If no DescriptionAttribute is found, return the enum value as a string
            return enumValue.ToString();
        }
    }

    // Holds all of the game configuration settings; only set once at the start of the game
    // Default GameDurationSeconds to 60; this is here in case I want to implement user-selected test duration later on
    public record GameConfig(Category Category, bool BlindInputMode, int GameDurationSeconds = 60);
}
