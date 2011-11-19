using System;
using System.Collections.Generic;

namespace MVVM
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable != null && action != null)
                foreach (var e in enumerable)
                    action(e);
        }
    }
}
