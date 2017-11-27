
using System.Collections;
using System.Linq;

namespace AXIntegrationApp.Helper
{
    public static class Extensions
    {
        /// <summary>
        /// Sort extension
        /// </summary>
        /// <param name="collection">IEnumerable collection.</param>
        /// <param name="sortBy">SortBy keyword</param>
        /// <param name="reverse">order</param>
        /// <returns></returns>
        public static IEnumerable Sort(this IEnumerable collection, string sortBy, bool reverse = false)
        {
            return collection.Sort(sortBy, reverse);
                //.OrderBy(sortBy + (reverse ? " descending" : ""));
        }
    }
}
