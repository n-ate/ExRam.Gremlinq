﻿using ExRam.Gremlinq.Core.Execution;
using ExRam.Gremlinq.Core.Serialization;
using static ExRam.Gremlinq.Core.GremlinQuerySource;

namespace ExRam.Gremlinq.Core.Tests
{
    public sealed class GroovyGremlinQuerySerializationTest : QuerySerializationTest, IClassFixture<GroovyGremlinQuerySerializationTest.Fixture>
    {
        public sealed class Fixture : GremlinqTestFixture
        {
            public Fixture() : base(g
                .ConfigureEnvironment(_ => _
                    .ConfigureSerializer(_ => _.ToGroovy())
                    .UseExecutor(GremlinQueryExecutor.Identity)))
            {
            }
        }

        public GroovyGremlinQuerySerializationTest(Fixture fixture, ITestOutputHelper testOutputHelper) : base(
            fixture,
            testOutputHelper)
        {
        }
    }
}
