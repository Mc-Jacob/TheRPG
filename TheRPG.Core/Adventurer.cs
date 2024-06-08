namespace TheRPG.Core;

/// <summary>
/// The base class describing the required properties and functionality of every type of player.
/// </summary>
public abstract class Adventurer : IHasStats, IHasAbilities
{
    public int Intelligence { get; set; }
    public int Strength { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int Dexterity { get; set; }
    public int Speed { get; set; }
    public int MaxHealth => CalcMaxHealth();
    public int CurrentHealth { get; set; }
    public int MaxMp => CalcMaxMp();
    public int CurrentMp { get; set; }
    public int Level { get; set; }
    public IEnumerable<Ability> Abilities { get; set; } = [];

    /// <summary>
    /// Calculates an adventurer's max health
    /// </summary>
    /// <returns>An <see cref="int"/> value setting MaxHealth"/></returns>
    protected abstract int CalcMaxHealth();

    /// <summary>
    /// Calculates an adventurer's max magic points.
    /// </summary>
    /// <returns>An <see cref="int"/> value setting MaxMp"/></returns>
    protected abstract int CalcMaxMp();
}