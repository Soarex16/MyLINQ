using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static int Count<TSource>(
            this IEnumerable<TSource> source) {

            if (source == null) throw new ArgumentNullException(nameof(source));

            var count = 0;
            foreach (var item in source) count++;

            return count;
        }

        public static int Count<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate) {

            if (source == null) throw new ArgumentNullException(nameof(source));

            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            var count = 0;
            foreach (var item in source)
                if (predicate(item))
                    count++;

            return count;
        }
    }
}