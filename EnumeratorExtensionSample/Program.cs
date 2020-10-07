using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace EnumeratorExtensionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach(int i in 10)
            // {
            //     Console.WriteLine(i);
            // }


            var collection = new MyCollection<string>();
            collection.Add("A");
            collection.Add("B");
            collection.Add("C");
            collection.Add("D");
            collection.Add("E");
            collection.Add("F");
            collection.Add("G");
            collection.Add("H");
            collection.Add("I");
            collection.Add("J");

            Console.WriteLine(collection.Capacity);
            Console.WriteLine(collection.Count);

            foreach (var item in collection )
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

   

    public static class IntExtensions
    {
        public static IEnumerator<int> GetEnumerator(this int max)
        {
            return Enumerable.Range(0, max).GetEnumerator(); 
        }
    }

    public static class MyCollectionExtension
    {
        public static IEnumerator<T> GetEnumerator<T>(this MyCollection<T> source)
        {
            for (int i = 0; i < source.Count; i++)
            {
                yield return source[i];
            }
        }
    }


    public class MyCollection <T>
    {
        private T[] _data;
      
        private int _count;

        public int Capacity => _data.Length;

        public int Count => _count;
     
        public T this[int index]
        {
            get { return _data[index]; }
            set 
            {
                if (index == _count || index < 0) throw new IndexOutOfRangeException();
                _data[index] = value; 
            }
        }


        public MyCollection () : this(4)
        {
           
        }

        public MyCollection (int capacity)
        {
            _count = 0;           
            CreateArray(capacity);
        }

        private void CreateArray(int capacity)
        {
            _data = new T[capacity];
        }

        public void Add(T obj)
        {
            if (_count == _data.Length )
            {
              
                var source = _data;
                CreateArray(_data.Length*2);
                Array.Copy(source, _data, source.Length);
            }

            _data[_count] = obj;
            _count++;
        }
    }
}
