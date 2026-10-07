using System;
using System.Collections.Generic;

namespace Generics.src
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(
            this IEnumerable<T> source,
            int pageNumber,
            int pageSize)
        {
            if (pageNumber <= 0)
                throw new ArgumentException(
                    "Page number must be greater than 0.");

            if (pageSize <= 0)
                throw new ArgumentException(
                    "Page size must be greater than 0.");

            int startIndex = (pageNumber - 1) * pageSize;
            int currentIndex = 0;

            foreach (T item in source)
            {
                if (currentIndex >= startIndex &&
                    currentIndex < startIndex + pageSize)
                {
                    yield return item;
                }

                if (currentIndex >= startIndex + pageSize)
                {
                    yield break;
                }

                currentIndex++;
            }
        }
        public static T FindById<T>(
            this IEnumerable<T> source,
            int id)
            where T : IHasId
                {
            foreach (T item in source)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return default;
        }
        
        
        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
            this IEnumerable<T> source)
            where T : IHasId
        {
            Dictionary<int, T> dictionary =
                new Dictionary<int, T>();

            foreach (T item in source)
            {
                dictionary.Add(item.Id, item);
            }

            return dictionary;
        }
    }
}