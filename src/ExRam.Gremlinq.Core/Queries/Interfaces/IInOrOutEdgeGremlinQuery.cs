﻿using System;

namespace ExRam.Gremlinq.Core
{
    public interface IInOrOutEdgeGremlinQueryBase : IEdgeGremlinQueryBase
    {
        new IEdgeOrVertexGremlinQuery<object> Lower();
    }

    public interface IInOrOutEdgeGremlinQueryBase<TEdge, TAdjacentVertex> :
        IInOrOutEdgeGremlinQueryBase,
        IEdgeGremlinQueryBase<TEdge>
    {
        IBothEdgeGremlinQuery<TEdge, TTargetVertex, TAdjacentVertex> From<TTargetVertex>(Func<IVertexGremlinQuery<TAdjacentVertex>, IVertexGremlinQueryBase<TTargetVertex>> fromVertexTraversal);
        new IBothEdgeGremlinQuery<TEdge, TTargetVertex, TAdjacentVertex> From<TTargetVertex>(StepLabel<TTargetVertex> stepLabel);

        IBothEdgeGremlinQuery<TEdge, TAdjacentVertex, TTargetVertex> To<TTargetVertex>(Func<IVertexGremlinQuery<TAdjacentVertex>, IVertexGremlinQueryBase<TTargetVertex>> toVertexTraversal);
        new IBothEdgeGremlinQuery<TEdge, TAdjacentVertex, TTargetVertex> To<TTargetVertex>(StepLabel<TTargetVertex> stepLabel);
    }

    public interface IInOrOutEdgeGremlinQueryBaseRec<TSelf> :
        IInOrOutEdgeGremlinQueryBase,
        IEdgeGremlinQueryBaseRec<TSelf>
        where TSelf : IInOrOutEdgeGremlinQueryBaseRec<TSelf>
    {

    }

    public interface IInOrOutEdgeGremlinQueryBaseRec<TEdge, TAdjacentVertex, TSelf> :
        IInOrOutEdgeGremlinQueryBaseRec<TSelf>,
        IInOrOutEdgeGremlinQueryBase<TEdge, TAdjacentVertex>,
        IEdgeGremlinQueryBaseRec<TEdge, TSelf>
        where TSelf : IInOrOutEdgeGremlinQueryBaseRec<TEdge, TAdjacentVertex, TSelf>
    {

    }

    public interface IInOrOutEdgeGremlinQuery<TEdge, TAdjacentVertex> :
        IInOrOutEdgeGremlinQueryBaseRec<TEdge, TAdjacentVertex, IInOrOutEdgeGremlinQuery<TEdge, TAdjacentVertex>>
    {
    }
}
