
namespace TheRPG.Core.Data;

public static class Options
{
    public static readonly Option OptionADemo = new()
    {
        Brief = "Choose option A.",
        Detail = "You look around and decide that Option A, is likely your best chance.",
        ActivateOptionSelection = OptionDelegates.ActivateOptionSelectionA
    };
}