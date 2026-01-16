
namespace GraphVisualizationEngine.Engine.Graph.Interfaces
{
    internal interface IGraph
    {
        IReadOnlyList<INode> Nodes { get; }
        IReadOnlyList<IEdge> Edges { get; }


        protected bool Contains(INode node)
        {
            return Nodes.Contains(node);
        }
    }
}
