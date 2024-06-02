using System.Linq.Expressions;
using System.Reflection;

namespace TheRPG.Core.Data;

public static class PointOfInterests
{
    public static readonly PointOfInterest TreasureChest = new()
    {
        Introduction = "You notice a locked chest",
        Detail = "There is a treasure chest ordained with intricate runes and stuff blah blah...",
        Options = ["Option 1", "Option 2", "Option 3"]
    };

    public static readonly PointOfInterest JustATest = new()
    {
        Introduction = "You notice a Test",
        Detail = "There is a test ordained with intricate runes and stuff blah blah...",
        Options = ["Option 1", "Option 2", "Option 3"]
    };

    public static List<PointOfInterest?> GetAllPoIs()
    {
        return typeof(PointOfInterests).GetMembers()
            .OfType<FieldInfo>()
            .Where(f => f.GetValue(f) is not null)
            .Select(f => (PointOfInterest?)f.GetValue(f)).ToList();
    }
}