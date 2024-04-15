using System.Text.Json.Serialization;
using DragonHelper.Components.Data;
using MudBlazor;

namespace DragonHelper.Components.Models;

[System.Serializable]
public class Character
{
    public string Campaign { get; set; } = String.Empty;
    
    public string Name { get; set; } = String.Empty;
    public string Race { get; set; } = String.Empty;
    public string ClassAndLevel { get; set; } = String.Empty;
    
    public int Experience { get; set; } = 0;
    public string Background { get; set; } = String.Empty;
    public string Alignment { get; set; } = String.Empty;
    
    public int Age { get; set; } = 21;
    public int Height { get; set; } = 150;
    public int Weight { get; set; } = 50;
    public string Eyes { get; set; } = String.Empty;
    public string Skin { get; set; } = String.Empty;
    public string Hair { get; set; } = String.Empty;
    public string Appearance { get; set; } = String.Empty;
    
    public string Backstory { get; set; } = String.Empty;
    public string AlliesAndOrganizations { get; set; } = String.Empty;

    public string Personality { get; set; } = String.Empty;
    public string Ideals { get; set; } = String.Empty;
    public string Bonds { get; set; } = String.Empty;
    public string Flaws { get; set; } = String.Empty;
    
    public string FeaturesAndTraits { get; set; } = String.Empty;
    public string ProficienciesAndLanguages { get; set; } = String.Empty;
    
    public int Strength { get; set; } = 8;
    public int Dexterity { get; set; } = 8;
    public int Constitution { get; set; } = 8;
    public int Intelligence { get; set; } = 8;
    public int Wisdom { get; set; } = 8;
    public int Charisma { get; set; } = 8;
    
    public int PassivePerception { get; set; } = 0;
    public int Inspiration { get; set; } = 0;
    public int ProficiencyBonus { get; set; } = 0;
    public int ArmorClass { get; set; } = 10;
    public int Initiative { get; set; } = 0;
    public int Speed { get; set; } = 30;
    
    public int HitPoints { get; set; } = 8;
    public int HitPointMaximum { get; set; } = 8;
    public string HitDice { get; set; } = String.Empty;
    public int DeathSaveSuccess { get; set; } = 0;
    public int DeathSaveFailure { get; set; } = 0;

    public int StrengthSavingThrow { get; set; } = 0;
    public int DexteritySavingThrow { get; set; } = 0;
    public int ConstitutionSavingThrow { get; set; } = 0;
    public int IntelligenceSavingThrow { get; set; } = 0;
    public int WisdomSavingThrow { get; set; } = 0;
    public int CharismaSavingThrow { get; set; } = 0;

    public int Acrobatics { get; set; } = 0;
    public int AnimalHandling { get; set; } = 0;
    public int Arcana { get; set; } = 0;
    public int Athletics { get; set; } = 0;
    public int Deception { get; set; } = 0;
    public int History { get; set; } = 0;
    public int Insight { get; set; } = 0;
    public int Intimidation { get; set; } = 0;
    public int Investigation { get; set; } = 0;
    public int Medicine { get; set; } = 0;
    public int Nature { get; set; } = 0;
    public int Perception { get; set; } = 0;
    public int Performance { get; set; } = 0;
    public int Persuasion { get; set; } = 0;
    public int Religion { get; set; } = 0;
    public int SleightOfHand { get; set; } = 0;
    public int Stealth { get; set; } = 0;
    public int Survival { get; set; } = 0;

    public string Equipment { get; set; } = String.Empty;
    public string Inventory { get; set; } = String.Empty;
    public int Cooper { get; set; } = 0;
    public int Silver { get; set; } = 0;
    public int Gold { get; set; } = 0;
    public int Platinum { get; set; } = 0;
    
    public string AttacksAndSpellcasting { get; set; } = String.Empty;
    public string SpellcastingAbility { get; set; } = String.Empty;
    public int SpellSaveDc { get; set; } = 0;
    public int SpellAttackBonus { get; set; } = 0;

    public string Cantrips { get; set; } = String.Empty;
    public int Level1SpellSlotTotal { get; set; } = 0;
    public int Level1SpellSlotExpended { get; set; } = 0; 
    public string Level1Spells { get; set; } = String.Empty;
    public int Level2SpellSlotTotal { get; set; } = 0;
    public int Level2SpellSlotExpended { get; set; } = 0; 
    public string Level2Spells { get; set; } = String.Empty;
    public int Level3SpellSlotTotal { get; set; } = 0;
    public int Level3SpellSlotExpended { get; set; } = 0; 
    public string Level3Spells { get; set; } = String.Empty;
    public int Level4SpellSlotTotal { get; set; } = 0;
    public int Level4SpellSlotExpended { get; set; } = 0; 
    public string Level4Spells { get; set; } = String.Empty;
    public int Level5SpellSlotTotal { get; set; } = 0;
    public int Level5SpellSlotExpended { get; set; } = 0; 
    public string Level5Spells { get; set; } = String.Empty;
    public int Level6SpellSlotTotal { get; set; } = 0;
    public int Level6SpellSlotExpended { get; set; } = 0; 
    public string Level6Spells { get; set; } = String.Empty;
    public int Level7SpellSlotTotal { get; set; } = 0;
    public int Level7SpellSlotExpended { get; set; } = 0; 
    public string Level7Spells { get; set; } = String.Empty;
    public int Level8SpellSlotTotal { get; set; } = 0;
    public int Level8SpellSlotExpended { get; set; } = 0; 
    public string Level8Spells { get; set; } = String.Empty;
    public int Level9SpellSlotTotal { get; set; } = 0;
    public int Level9SpellSlotExpended { get; set; } = 0; 
    public string Level9Spells { get; set; } = String.Empty;
}