using DragonHelper.Components.Data;
using DragonHelper.Components.Models;
using Microsoft.AspNetCore.Components;

namespace DragonHelper.Components.Shared;

public partial class CharacterSheet
{
    [Parameter] public Character Character { get; set; } = new Character();
    bool showCharacter { get; set; } = false;
    bool showBasic { get; set; } = false;
    bool showStats { get; set; } = false;
    bool showAttributes { get; set; } = false;
    bool showSkills { get; set; } = false;
    bool showSavingThrows { get; set; } = false;
    bool showItems { get; set; } = false;
    bool showSpellBook { get; set; } = false;
    bool showPhysical { get; set; } = false;
    bool showStory { get; set; } = false;
    bool showPersonality { get; set; } = false;
    bool showTraits { get; set; } = false;
}