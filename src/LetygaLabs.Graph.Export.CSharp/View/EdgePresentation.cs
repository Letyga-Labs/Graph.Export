namespace LetygaLabs.Graph.Export.CSharp.View;

public record EdgePresentation(
    EdgeLineType LineType,
    IColorKey LineColorKey,
    EdgeArrowType SourceArrow = EdgeArrowType.None,
    EdgeArrowType TargetArrow = EdgeArrowType.None,
    Uri? Url = null,
    string? Tooltip = null,
    string? UpperSourceLabel = null,
    string? BottomSourceLabel = null,
    string? UpperCenterLabel = null,
    string? BottomCenterLabel = null,
    string? UpperTargetLabel = null,
    string? BottomTargetLabel = null
);
