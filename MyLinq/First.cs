using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static TSource First<TSource>(
            this IEnumerable<TSource> source) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            using (var e = source.GetEnumerator()) {
                if (e.MoveNext()) return e.Current;
            }

            throw new InvalidOperationException("Input sequence is empty");
        }

        public static TSource First<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
                if (predicate(item))
                    return item;

            throw new InvalidOperationException("Element not found or input sequence is empty");
        }
    }
}