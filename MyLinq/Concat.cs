﻿using System;
using System.Collections.Generic;

namespace MyLinq {
    public static partial class Enumerable {
        public static IEnumerable<TSource> Concat<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second) {
            if (first == null) throw new ArgumentNullException(nameof(first));

            if (second == null) throw new ArgumentNullException(nameof(second));

            return ConcatImpl(first, second);
        }

        internal static IEnumerable<TSource> ConcatImpl<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second) {
            foreach (var item in first)
                yield return item;

            foreach (var item in second)
                yield return item;
        }
    }
}