﻿using System.Collections.Generic;

namespace MoreLinq.Pull
{
    using System.Linq;

    public static class Concatenation
    {
        /// <summary>
        /// Returns a sequence consisting of the head element and the given tail elements.
        /// </summary>
        /// <typeparam name="T">Type of sequence</typeparam>
        /// <param name="head">Head element of the new sequence.</param>
        /// <param name="tail">All elements of the tail. Must not be null.</param>
        /// <returns>A sequence consisting of the head elements and the given tail elements.</returns>
        public static IEnumerable<T> Concat<T>(this T head, IEnumerable<T> tail)
        {
            tail.ThrowIfNull("tail");
            return Enumerable.Repeat(head, 1).Concat(tail);
        }

        /// <summary>
        /// Returns a sequence consisting of the head elements and the given tail element.
        /// </summary>
        /// <typeparam name="T">Type of sequence</typeparam>
        /// <param name="head">All elements of the head. Must not be null.</param>
        /// <param name="tail">Tail element of the new sequence.</param>
        /// <returns>A sequence consisting of the head elements and the given tail element.</returns>
        public static IEnumerable<T> Concat<T>(this IEnumerable<T> head, T tail)
        {
            head.ThrowIfNull("head");
            return head.Concat(Enumerable.Repeat(tail, 1));
        }
    }
}