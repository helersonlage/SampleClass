using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new Entity();

            people.Age = Entity.StaticGetAge_1(new DateTime(1978,01,01));
            Console.WriteLine($"Age Static is {people.Age}");

            people.Age = people.NonStaticReturnGetAge(new DateTime(1979, 01, 01));
            Console.WriteLine($"Age Static is {people.Age}");

            people.NonStaticVoidGetAge_(new DateTime(1980, 01, 01));
            Console.WriteLine($"Age Static is {people.Age}");

            Console.ReadLine();
        }
    }
}




namespace ConsoleApp1
{
    public class Entity
    {        
        public int Age { get; set; }

        public static int StaticGetAge_1(DateTime birthDay)
        {
            return  DateTime.Now.Year - birthDay.Year;
        }


        public int NonStaticReturnGetAge(DateTime birthDay)
        {
            return DateTime.Now.Year - birthDay.Year;
        }


        public void NonStaticVoidGetAge_(DateTime birthDay)
        {
            Age = DateTime.Now.Year - birthDay.Year;
        }



    }
}