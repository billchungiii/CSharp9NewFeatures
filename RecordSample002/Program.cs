using System;

namespace RecordSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person { id = 10, Age = 28, Name = "Bill" };
            var p2 = p1 with { id = 11, Name = "Tom" };

            Console.WriteLine(p2);

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
