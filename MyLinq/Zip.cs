using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinq {
    public static partial class Enumerable {
        public static IEnumerable<(TFirst, TSecond)> Zip<TFirst, TSecond> (
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second) {

            if (first == null) {
                throw new ArgumentNullException("first");
            }

            if (second == null) {
                throw new ArgumentNullException("second");
            }

            return ZipÍmpl(first, second);
        }

        internal static IEnumerable<(TFirst, TSecond)> ZipÍmpl<TFirst, TSecond> (
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second) {

            IEnumerator<TFirst> f = first.GetEnumerator();
            IEnumerator<TSecond> s = second.GetEnumerator();

            while (f.MoveNext() && s.MoveNext()) {
                yield return (f.Current, s.Current);
            }
        }
    }
}
