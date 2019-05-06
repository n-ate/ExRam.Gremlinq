﻿using System;
using System.Collections.Immutable;

namespace ExRam.Gremlinq.Core
{
    public interface IGraphElementModel
    {
        IImmutableDictionary<Type, string> Labels { get; }
    }
}
