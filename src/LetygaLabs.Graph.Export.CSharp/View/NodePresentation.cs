namespace LetygaLabs.Graph.Export.CSharp.View;

public record NodePresentation
{
    public NodeShape Shape       { get; init; }
    public IColorKey StrokeColor { get; init; }
    public IColorKey FillColor   { get; init; }

    public string? Content { get; init; }

    public string? Label { get; init; }

    public Uri? Url { get; init; }

    public string? Tooltip { get; init; }
}
