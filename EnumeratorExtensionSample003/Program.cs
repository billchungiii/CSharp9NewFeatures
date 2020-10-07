using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EnumeratorExtensionSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in 2..11)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static class RangeEXtension
    {
        public static IEnumerator<int> GetEnumerator(this Range range)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                yield return i;
            }
        }
    }
}
