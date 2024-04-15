using System.Text.Json;
using DragonHelper.Components.Models;

namespace DragonHelper.Components.Data;

public static class Data
{
    public static List<Campaign> Campaign = new();
    public static List<Character> Character = new();

    public static string Path = "./Data";

    public static void RefreshData()
    {
        Campaign = new();
        Character = new();
        var directories = Directory.GetDirectories(Path);
        foreach (var directory in directories)
        {
            var files = Directory.GetFiles(directory);
            foreach (var file in files)
            {
                if (file.StartsWith($"{directory}/Campaign-"))
                {
                    string text = File.ReadAllText(file);
                    Campaign campaign = JsonSerializer.Deserialize<Campaign>(text);
                    Campaign.Add(campaign);
                }
                else if (file.StartsWith($"{directory}/Character-"))
                {
                    string text = File.ReadAllText(file);
                    Character character = JsonSerializer.Deserialize<Character>(text);
                    Character.Add(character);
                    
                }
            }
        }
    }
}