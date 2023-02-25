namespace LetygaLabs.Graph.Export.CSharp.View;

public record NodePresentation(
    NodeShape Shape,
    IColorKey StrokeColor,
    IColorKey FillColor,
    string? Content,
    string? Label = null,
    Uri? Url = null,
    string? Tooltip = null
);
