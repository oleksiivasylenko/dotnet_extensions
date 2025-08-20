using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Execute an action for each item of the collection
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
        /// Execute an action for each item of the collection
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
        /// Replace the item in the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="oldItem">Item which will be replaced</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>List with replaced item</returns>
        public static List<T> Replace<T>(this List<T> source, T oldItem, T newItem)
        {
            if (source == null || oldItem == null || newItem == null)
                throw new ArgumentNullException("(source || oldItem || newItem) can't be null!");

            var indexOfOldVaule = source.IndexOf(oldItem);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("The source does not contain old item!");

            source[indexOfOldVaule] = newItem;
            return source;
        }

        /// <summary>
        /// Replace the item in the array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="oldItem">Item which will be replaced</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>Array with replaced item</returns>
        public static T[] Replace<T>(this T[] source, T oldItem, T newItem)
        {
            if (source == null || oldItem == null || newItem == null)
                throw new ArgumentNullException("(source || oldItem || newItem) can't be null!");

            var indexOfOldVaule = Array.IndexOf(source, oldItem);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("The source does not contain old item!");

            source[indexOfOldVaule] = newItem;
            return source;
        }

        /// <summary>
        /// Replace the item the a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="expression">Expression to find item in a collection.</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>List with replaced item</returns>
        public static List<T> Replace<T>(this List<T> source, Predicate<T> expression, T newItem)
        {
            if (source == null || newItem == null)
                throw new ArgumentNullException("(source || newItem) can't be null!");

            var indexOfOldVaule = source.FindIndex(expression);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("The source does not contain old item!");

            source[indexOfOldVaule] = newItem;
            return source;
        }

        /// <summary>
        /// Replace the item in the array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source</param>
        /// <param name="expression">Expression to find item in a collection.</param>
        /// <param name="newItem">Item which will be inserted</param>
        /// <returns>Array with replaced item</returns>
        public static T[] Replace<T>(this T[] source, Predicate<T> expression, T newItem)
        {
            if (source == null || newItem == null)
                throw new ArgumentNullException("(source || newItem) can't be null!");

            var indexOfOldVaule = Array.FindIndex(source, expression);

            if (indexOfOldVaule == -1)
                throw new ArgumentOutOfRangeException("The source does not contain old item!");

            source[indexOfOldVaule] = newItem;
            return source;
        }
    }
}
