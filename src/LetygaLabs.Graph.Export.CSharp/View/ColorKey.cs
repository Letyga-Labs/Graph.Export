using System.Drawing;

namespace LetygaLabs.Graph.Export.CSharp.View;

public static class ColorKey
{
    public static IColorKey ByType<T>()
    {
        return new ColorKeyByType(typeof(T));
    }

    public static IColorKey ByName(string name)
    {
        return new ColorKeyByName(name);
    }

    public static IColorKey ByColor(Color color)
    {
        return new ColorKeyByColor(color);
    }
}

internal record ColorKeyByType(Type Type) : IColorKey;

internal record ColorKeyByName(string Name) : IColorKey;

internal record ColorKeyByColor(Color Color) : IColorKey;
