using System.Text.Json;
using DragonHelper.Components.Models;

namespace DragonHelper.Components.Data;

public static class Global
{
    public static string GetAttributeBonus(int value)
    {
        if (value < 2) return "(-5)";
        else if (value < 4) return "(-4)";
        else if (value < 6) return "(-3)";
        else if (value < 8) return "(-2)";
        else if (value < 10) return "(-1)";
        else if (value < 12) return "(+0)";
        else if (value < 14) return "(+1)";
        else if (value < 16) return "(+2)";
        else if (value < 18) return "(+3)";
        else if (value < 20) return "(+4)";
        else if (value < 22) return "(+5)";
        else if (value < 24) return "(+6)";
        else if (value < 26) return "(+7)";
        else if (value < 28) return "(+8)";
        else if (value < 30) return "(+9)";
        else if (value < 32) return "(+10)";
        else return "null";
    }
    
    public static void UpdateCharacter(Character character)
    {
        var jsonString = JsonSerializer.Serialize(character);
        File.WriteAllText($"{Data.Path}/{character.Campaign}/Character-{character.Name}", jsonString);   
        Data.RefreshData();
    }
}