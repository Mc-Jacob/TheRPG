namespace TheRPG.Core;

public class PointOfInterest
{
    public required string Introduction { get; init; }
    public required string Detail { get; init; }
    public required List<string> Options { get; init; }
}