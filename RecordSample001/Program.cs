using System;
using System.Runtime.CompilerServices;

namespace RecordSample001
{
    class Program
    {       

        static void Main(string[] args)
        {
            var p1 = new Person { id = 10, Age = 28, Name = "Bill" };
            var p2 = new Person { id = 10, Age = 28, Name = "Bill" };

            Console.WriteLine(object.ReferenceEquals(p1, p2));
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(object.Equals(p1, p2));
            Console.WriteLine(p1 == p2);

            Console.WriteLine(p1);

            Console.ReadLine();
        }
    }

   
    record Person
    {
        public int id;
        public string Name { get; init; }
        public int Age { get; init; }
    }

   
   
}
