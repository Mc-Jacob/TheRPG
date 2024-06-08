namespace TheRPG.Core;

public class OptionResponse
{
    public required string ResultVerbage { get; set; }
    public required Adventurer UpdatedAdventurer { get; set; }
    public bool Success { get; set; }
}