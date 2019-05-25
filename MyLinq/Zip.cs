using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static IEnumerable<(TFirst, TSecond)> Zip<TFirst, TSecond>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second) {
            if (first == null) throw new ArgumentNullException(nameof(first));

            if (second == null) throw new ArgumentNullException(nameof(second));

            return ZipImpl(first, second);
        }

        internal static IEnumerable<(TFirst, TSecond)> ZipImpl<TFirst, TSecond>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second) {
            using (var f = first.GetEnumerator())
            using (var s = second.GetEnumerator()) {
                while (f.MoveNext() && s.MoveNext()) yield return (f.Current, s.Current);
            }
        }
    }
}