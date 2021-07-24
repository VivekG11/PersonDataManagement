using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Details Of persons....");
            List<Person> people = new List<Person>();
            AddDetails(people);
            RetrieveAge(people);

        }

        public static void AddDetails(List<Person> people)
        {
            people.Add(new Person("1234", "Vivek", "LB Nagar", 29));
            people.Add(new Person("3421", "Aditya", "Kukatpally", 37));
            people.Add(new Person("1129", "Vinay", "Chennai", 54));
            people.Add(new Person("3901", "Pavani", "Kadapa", 35));
            people.Add(new Person("6672", "Guna", "Vizag", 26));


            foreach (Person i in people)
            {

                Console.WriteLine("Details are {0} , {1} , {2}, {3} .", i.SSN, i.Name, i.Address, i.Age);
            }


        }

        public static void RetrieveAge(List<Person> people)
        {
            //Displaying persons under condition using lambda expression
            foreach (Person i in people.FindAll(a => (a.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + i.Name + "Age :" + i.Age);
            }

        }
    }
}
