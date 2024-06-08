namespace TheRPG.Core;

/// <summary>
/// Interface requiring implementors to include stats used for players and NPCs.
/// stats help define a player's or NPC's power Level.
/// </summary>
public interface IHasStats
{
    public int Intelligence { get; set; }
    public int Strength { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int Dexterity { get; set; }
    public int Speed { get; set; }
    public int MaxHealth { get; } // Only get because this will be a calculated property.
    public int CurrentHealth { get; set; }
    public int MaxMp { get; }  // Only get because this will be a calculated property.
    public int CurrentMp { get; set; }
    public int Level { get; set; }
}