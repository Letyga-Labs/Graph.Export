namespace LetygaLabs.Graph.Export.CSharp.View;

/// <summary>
/// Определяет внешний вид для экспортируемого графа. Например, мы хотим,
/// чтобы такие-то ребра были зелененькие, а такие-то узлы имели иконку очереди сообщений.
/// </summary>
public record GraphPresentation<TNode, TEdge>(
    string                              Title,
    EdgePaintingMode                    EdgePaintingMode,
    Func<TNode, NodePresentation>       NodePresentationProvider,
    Func<TEdge, EdgePresentation>       EdgePresentationProvider,
    IDictionary<TNode, INodeGroup>?     Grouping                  = null,
    Func<INodeGroup, NodePresentation>? GroupPresentationProvider = null
)
    where TEdge : IEdge<TNode>;
