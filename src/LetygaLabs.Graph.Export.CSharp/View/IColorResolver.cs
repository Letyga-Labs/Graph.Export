using System.Drawing;

namespace LetygaLabs.Graph.Export.CSharp.View;

public interface IColorResolver
{
    Color? Resolve(IColorKey colorKey);
}
