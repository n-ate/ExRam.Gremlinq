﻿using System.Collections.Immutable;

namespace ExRam.Gremlinq.Core
{
    internal static class SpanExtensions
    {
        public static bool All<T>(this Span<T> span, Predicate<T> predicate)
        {
            for (var i = 0; i < span.Length; i++)
            {
                if (!predicate(span[i]))
                    return false;
            }

            return true;
        }

        public static ImmutableArray<T> ToImmutableArray<T>(this Span<T> span)
        {
            var builder = ImmutableArray
                .CreateBuilder<T>(span.Length);

            for (var i = 0; i < span.Length; i++)
            {
                builder
                    .Add(span[i]);
            }

            return builder.ToImmutable();
        }
    }
}
