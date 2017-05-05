using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Execute ab action on each item in collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">Items collection</param>
        /// <param name="action">The action</param>
        public static void Do<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
                action(item);
        }

        /// <summary>
        /// Execute ab action on each item in collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">Items collection</param>
        /// <param name="action">The action</param>
        public static void Do<T>(this IEnumerable items, Action<T> action)
        {
            foreach (var item in items.OfType<T>())
                action(item);
        }

        /// <summary>
        /// Replace an item in a collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="oldItem">Item which will be replaced</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>Colection with replaced item</returns>
        public static List<T> Replace<T>(this List<T> source, T newItem, T oldItem)
        {
            if (source == null || oldItem == null || newItem == null)
                throw new ArgumentNullException("source || oldItem || newItem");

            var indexOfOldVaule = -1;
            indexOfOldVaule = source.IndexOf(oldItem);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("source does not contain oldItem");

            source[indexOfOldVaule] = newItem;
            return source;
        }

        /// <summary>
        /// Replace an item in a collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="oldItem">Item which will be replaced</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>Colection with replaced item</returns>
        public static T[] Replace<T>(this T[] source, T newItem, T oldItem)
        {
            if (source == null || oldItem == null || newItem == null)
                throw new ArgumentNullException("source || oldItem || newItem");

            var indexOfOldVaule = -1;
            indexOfOldVaule = Array.IndexOf(source, oldItem);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("source does not contain oldItem");

            source[indexOfOldVaule] = newItem;
            return source;
        }

        /// <summary>
        /// Replace an item in a collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="expression">Expression to find item in a collection.</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>Colection with replaced item</returns>
        public static List<T> Replace<T>(this List<T> source, Predicate<T> expression, T newItem)
        {
            if (source == null || newItem == null)
                throw new ArgumentNullException("source || newItem");

            var indexOfOldVaule = -1;
            indexOfOldVaule = source.FindIndex(expression);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("source does not contain oldItem");

            source[indexOfOldVaule] = newItem;
            return source;
        }

        /// <summary>
        /// Replace an item in a collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="expression">Expression to find item in a collection.</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>Colection with replaced item</returns>
        public static T[] Replace<T>(this T[] source, Predicate<T> expression, T newItem)
        {
            if (source == null || newItem == null)
                throw new ArgumentNullException("source || newItem");

            var indexOfOldVaule = -1;
            indexOfOldVaule = Array.FindIndex(source, expression);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("source does not contain oldItem");

            source[indexOfOldVaule] = newItem;
            return source;
        }
    }
}
