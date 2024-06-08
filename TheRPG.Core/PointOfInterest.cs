namespace TheRPG.Core;

public class PointOfInterest
{
    public required string Introduction { get; init; }
    public required string Detail { get; init; }
    public required List<Option> Options { get; init; }
}