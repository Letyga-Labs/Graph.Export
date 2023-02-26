using System.Drawing;

namespace LetygaLabs.Graph.Export.CSharp.View;

public class ColorResolver : IColorResolver
{
    private readonly Dictionary<IColorKey, Color?> _registry = new();

    public Color? this[IColorKey colorKey]
    {
        get => _registry[colorKey];
        set => _registry[colorKey] = value;
    }

    public Color? Resolve(IColorKey colorKey)
    {
        return colorKey switch
        {
            ColorKeyByColor byColor => byColor.Color,
            _                       => _registry.GetValueOrDefault(colorKey),
        };
    }
}
