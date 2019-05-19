using System.Collections.Generic;
using System;

namespace Where {
    public static partial class Enumerable {
        
        public static IEnumerable<TSource> Where<TSource>(
            this IEnumerable<TSource> source, 
            Func<TSource, bool> predicate) {

            if (source == null) {
                throw new ArgumentNullException("source");
            }

            if (predicate == null) {
                throw new ArgumentNullException("predicate");
            }

            return WhereIterator(source, predicate);
        }

        internal static IEnumerable<TSource> WhereIterator<TSource>(
            this IEnumerable<TSource> source, 
            Func<TSource, bool> predicate) {

            foreach (var item in source) {
                if (predicate(item)) {
                    yield return item;
                }
            }
        }
    }
}
