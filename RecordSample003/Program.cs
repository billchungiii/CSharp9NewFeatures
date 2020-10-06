using System;

namespace RecordSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
        }
    }

    // record Person(string Name, int Age);

    record Person
    {
        public string Name { get; init; }

        public int Age { get; init; }

        protected Person(Person original)
        {
            this.Name = original.Name;
            this.Age = original.Age;
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void Deconstruct(out string Name, out int Age)
        {
            Name = this.Name;
            Age = this.Age;
        }
    }
}
