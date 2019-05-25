using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static IEnumerable<TSource> Append<TSource>(
            this IEnumerable<TSource> source,
            TSource element) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            if (element == null) throw new ArgumentNullException(nameof(element));

            return AppendImpl(source, element);
        }

        internal static IEnumerable<TSource> AppendImpl<TSource>(
            this IEnumerable<TSource> source,
            TSource element) {
            foreach (var item in source)
                yield return item;

            yield return element;
        }
    }
}