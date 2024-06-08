namespace TheRPG.Core;

/// <summary>
/// Interface requiring implementors to include <see cref="Ability"/> collection./>
/// </summary>
public interface IHasAbilities
{
    public IEnumerable<Ability> Abilities { get; set; }
}