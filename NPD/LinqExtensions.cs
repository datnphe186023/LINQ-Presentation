using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPD
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> source, int n)
        {
            var buffer = new Queue<T>();

            foreach (var item in source)
            {
                buffer.Enqueue(item);
                if (buffer.Count > n)
                    yield return buffer.Dequeue();
            }
        }
    }
}
