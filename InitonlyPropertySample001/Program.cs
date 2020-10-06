using System;

namespace InitonlyPropertySample001
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person() { Name = "Bill", Age = 12 };
            var c1 = new Circle { Radius = 100 };

            Console.WriteLine(p1.Name);
            Console.WriteLine(c1.Radius);

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {        }      
    }

    struct Circle
    {
        public double Radius { get; init; }
    }

   class Rectangle
    {
        public double Width { get; }

        public double Height { get; }

        public Rectangle (double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
