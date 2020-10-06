using System;

namespace InitonlyPropertySample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Bill", 28, "A001");

            Console.WriteLine($"{s1.Name},{s1.Age},{s1.Id}");
        }
    }

    class Person
    {
        public string Name { get; init; }
        public int Age { get; init; }      
    }

    class Student : Person
    {
        public string Id { get; init; }

        public Student() { }
        public Student(string name, int age, string id)
        {
            base.Name = name;
            base.Age = age;
            this.Id = id;
        }
    }
}
