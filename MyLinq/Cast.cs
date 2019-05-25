using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source) {
            if (source == null) throw new ArgumentNullException(nameof(source));

            return CastImpl<TResult>(source);
        }

        internal static IEnumerable<TResult> CastImpl<TResult>(this IEnumerable source) {
            foreach (var item in source)
                yield return (TResult) item;
        }
    }
}