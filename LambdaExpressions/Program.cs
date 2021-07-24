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
            RetrieveDetails(people);
            AverageAge(people);
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

        public static void RetrieveDetails(List<Person> people)
        {
            if (people.Count <= 0)
            {
                Console.WriteLine("No data found ......");
            }
            else
            {
                Console.WriteLine("People between 12 and 50 are");
                foreach (Person person in people.FindAll(b => (b.Age > 12 && b.Age < 50)).ToList())
                {
                    Console.WriteLine("Name :" + person.Name + "Age :" + person.Age);
                }
            }
        }

        public static void AverageAge(List<Person> people)
        {
            AddDetails(people);
            if (people.Count < 0)
            {
                Console.WriteLine("Empty, No data found");
            }
            else
            {
                double avg = people.Average(b => b.Age);
                Console.WriteLine("Average of age from list is :" + avg);
            }

           
        }



    }
}
