namespace TheRPG.Core;

/// <summary>
/// Class describing the concept of an ability possessed by NPCs and Players.
/// </summary>
public class Ability
{
    public required string AbilityName { get; set; }
    public required string AbilityDescription { get; set; }
    
    // A lot more to do here because currently we haven't really defined what an ability is. 
}