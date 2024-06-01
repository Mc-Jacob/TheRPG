using System.Linq.Expressions;

namespace TheRPG.Core.Data;

public static class PointOfInterests
{
    public static readonly PointOfInterest TreasureChest = new()
    {
        Introduction = "You notice a locked chest",
        Detail = "There is a treasure chest ordained with intricate runes and stuff blah blah...",
        Options = ["Option 1", "Option 2", "Option 3"]
    };
}