﻿using ExRam.Gremlinq.Core;
using Gremlin.Net.Driver;

namespace ExRam.Gremlinq.Providers.WebSocket
{
    public interface IWebSocketRemoteConfigurator
    {
        IWebSocketRemoteConfigurator WithClient(IGremlinClient client);

        IWebSocketRemoteConfigurator WithSerializerFactory(IGraphsonSerializerFactory serializer);

        IGremlinQueryExecutor Build();
    }
}
