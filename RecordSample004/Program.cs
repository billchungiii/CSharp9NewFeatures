using System;

namespace RecordSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Bill", 28);
            var s1 = new Student("Bill", 28, "A001");
            Person s2 = new Student("Bill", 28, "B001");

            Console.WriteLine(s1.Equals(p));
            Console.WriteLine(s1.Equals(s2));
            
            Console.ReadLine();
        }
    }

    record Person(string Name, int Age);

    record Student(string Name, int Age, string Id) : Person(Name, Age);

   

    record Shape
    {
        public string Name { get; init; }
    }

    record Rectangle : Shape;

    class ABC : IEquatable<ABC>
    {
        public bool Equals(ABC other)
        {
            throw new NotImplementedException();
        }
    }

   
}
