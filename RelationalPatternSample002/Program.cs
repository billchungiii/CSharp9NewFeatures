using System;
using System.Collections.Generic;

namespace RelationalPatternSample002
{
    class Program
    {
        static void Main(string[] args)
        {


            foreach (var item in GetStudentOver70_8())
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetStudentOver70_9())
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }




        static IEnumerable<string> GetStudentOver70_8()
        {
            var people = Create();
            foreach (var p in people)
            {

                if (p is Student { Gender: Gender.Male, Name: string name, Score: int score } && score > 70)
                {
                    yield return name;
                }
            }
        }



        static IEnumerable<string> GetStudentOver70_9()
        {
            var people = Create();
            foreach (var p in people)
            {

                if (p is Student { Gender: Gender.Male, Name: string name, Score: > 70 })
                {
                    yield return name;
                }
            }
        }


        
        static List<IPerson> Create()
        {
            return new List<IPerson>
                   {
                       new Teacher {Name= "Bill" },
                       new Teacher {Name= "David"},
                       new Student{ Name = "魯夫",  Gender = Gender.Male , Score= 60},
                       new Student{ Name = "妮可羅賓",  Gender = Gender.Female , Score= 82},
                       new Student{ Name = "娜美",   Gender = Gender.Female, Score= 70 },
                       new Student{ Name = "騙人布" ,Gender = Gender.Male, Score= 55 },
                       new Student{ Name = "香吉士",  Gender = Gender.Male, Score= 58 },
                       new Student{ Name = "喬巴",   Gender = Gender.Male, Score= 67 },
                       new Student{ Name = "布魯克",  Gender = Gender.Male, Score= 99 },
                       new Student{ Name = "索隆",  Gender = Gender.Male, Score= 80 },
                       new Student{ Gender = Gender.Male , Score= 60},                      
                   };
        }

    }

    interface IPerson
    {
        Guid ID { get; set; }
        string Name { get; set; }
    }

    class Teacher : IPerson
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }

    class Student : IPerson
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public bool IsPassed
        {
            get { return Score > 59; }
        }

        public Gender Gender { get; set; }

        public int Score { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}
