using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Type
{
    public static class TypeExtensions
    {
        /// <summary>
        /// Makes deep copy of an object. Depends on NewtonSoft.Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <returns>Cloned T</returns>
        public static T DeepClone<T>(this T self)
        {
            if (ReferenceEquals(self, null))
                return default(T);

            var jsonCopy = JsonConvert.SerializeObject(self);
            return JsonConvert.DeserializeObject<T>(jsonCopy);
        }

        /// <summary>
        /// Indicates whether item in a list of items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">Source item</param>
        /// <param name="list">list of items</param>
        /// <returns>True if list contains source item</returns>
        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            return list.Contains(source);
        }

        /// <summary>
        /// Allows to add item to collection in more readable way. Ex item.AddTo(collection)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <param name="coll"></param>
        /// <returns>Added item</returns>
        public static T AddTo<T>(this T self, ICollection<T> coll)
        {
            coll.Add(self);
            return self;
        }
    }
}
