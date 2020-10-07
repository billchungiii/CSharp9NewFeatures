using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumeratorExtensionSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in 10)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static class IntExtensions
    {
        public static IEnumerator<int> GetEnumerator(this int max)
        {
            return Enumerable.Range(0, max).GetEnumerator();
        }
    }

    

}
