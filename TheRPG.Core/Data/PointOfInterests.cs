using System.Linq.Expressions;
using System.Reflection;
using TheRPG.Core.Data.OptionClasses;

namespace TheRPG.Core.Data;

public static class PointOfInterests
{
    public static readonly PointOfInterest TreasureChest = new()
    {
        Introduction = "You notice a locked chest",
        Detail = "There is a treasure chest ordained with intricate runes and stuff blah blah...",
        Options = [Options.OptionADemo, Options.OptionADemo, Options.OptionADemo]
    };
    
    public static readonly PointOfInterest Ruins = new()
    {
        Introduction = "You notice ruins in the distance",
        Detail = "This is detail about the ruins such as architecture, age, vegetation, smells, etc...",
        Options = [Options.OptionADemo, Options.OptionADemo, Options.OptionADemo]
    };

    public static List<PointOfInterest?> GetAllPoIs()
    {
        return typeof(PointOfInterests).GetMembers()
            .OfType<FieldInfo>()
            .Where(f => f.GetValue(f) is not null)
            .Select(f => (PointOfInterest?)f.GetValue(f)).ToList();
    }
}