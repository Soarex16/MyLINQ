using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static bool Any<TSource>(
            this IEnumerable<TSource> source) {

            if (source == null) throw new ArgumentNullException(nameof(source));

            using (var e = source.GetEnumerator()) {
                if (e.MoveNext()) return true;
            }

            return false;
        }

        public static bool Any<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate) {

            if (source == null) throw new ArgumentNullException(nameof(source));

            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
                if (predicate(item))
                    return true;

            return false;
        }
    }
}