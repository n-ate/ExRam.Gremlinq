using System.Collections.Immutable;

namespace ExRam.Gremlinq
{
    public interface IGremlinQuery : IGremlinSerializable
    {
        string TraversalSourceName { get; }
        IImmutableList<GremlinStep> Steps { get; }
        IIdentifierFactory IdentifierFactory { get; }
        //(int depth, int index) TreeLocation { get; }
        IImmutableDictionary<string, StepLabel> StepLabelMappings { get; }
    }

    // ReSharper disable once UnusedTypeParameter
    public interface IGremlinQuery<out T> : IGremlinQuery
    {

    }

    // ReSharper disable once UnusedTypeParameter
    public interface IGremlinQuery<out TEdge, out TAdjacentVertex> : IGremlinQuery<TEdge>
    {

    }

    // ReSharper disable UnusedTypeParameter
    public interface IGremlinQuery<out TOutVertex, out TEdge, out TInVertex> : IGremlinQuery<TEdge>
    // ReSharper restore UnusedTypeParameter
    {

    }
}