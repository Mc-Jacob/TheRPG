namespace TheRPG.Core;

public class Option
{
    public required string Brief { get; set; }
    public required string Detail { get; set; }

    /// <summary>
    /// The business logic to modify <see cref="Adventurer"/> based on result, and
    /// return <see cref="OptionResponse"/> describing the changes and other updates./>
    /// </summary>
    public required Func<Adventurer,OptionResponse> ActivateOptionSelection { get; set; }
}