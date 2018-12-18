﻿using System;
using System.Linq;
using ExRam.Gremlinq.Core.Tests;
using FluentAssertions;
using Xunit;
using static ExRam.Gremlinq.Core.GremlinQuerySource;

namespace ExRam.Gremlinq.Providers.CosmosDb.Tests
{
    public class GroovySerializationTest : GroovySerializationTest<CosmosDbGroovyGremlinQueryElementVisitor>
    {
        [Fact]
        public void Limit_overflow()
        {
            g
                .V()
                .Limit((long)int.MaxValue + 1)
                .Invoking(x => new CosmosDbGroovyGremlinQueryElementVisitor().Visit(x))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Where_property_array_intersects_empty_array2()
        {
            g
                .V<User>()
                .Where(t => t.PhoneNumbers.Intersect(new string[0]).Any())
                .Should()
                .SerializeToGroovy<CosmosDbGroovyGremlinQueryElementVisitor>("g.V().hasLabel(_a).not(__.identity())")
                .WithParameters("User");
        }
    }
}
