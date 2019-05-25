using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static IEnumerable<TResult> Select<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return SelectImpl(source, selector);
        }

        internal static IEnumerable<TResult> SelectImpl<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector) {
            foreach (var item in source) yield return selector(item);
        }
    }
}