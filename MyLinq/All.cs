using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static bool All<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
                if (!predicate(item))
                    return false;

            return true;
        }
    }
}