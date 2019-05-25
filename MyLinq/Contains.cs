using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static bool Contains<TSource>(
            this IEnumerable<TSource> source,
            TSource value) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            if (value == null) throw new ArgumentNullException(nameof(value));

            foreach (var item in source)
                if (item.Equals(value))
                    return true;

            return false;
        }

        public static bool Contains<TSource>(
            this IEnumerable<TSource> source,
            TSource value,
            IEqualityComparer<TSource> comparer) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            if (value == null) throw new ArgumentNullException(nameof(value));

            if (comparer == null) throw new ArgumentNullException(nameof(comparer));

            foreach (var item in source)
                if (comparer.Equals(item, value))
                    return true;

            return false;
        }
    }
}