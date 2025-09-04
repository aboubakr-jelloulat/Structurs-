using System;
using System.Collections.Generic;
using System.Linq;

namespace List._08_Working_with_a_List_of_Custom_Objects
{
    public partial class CustomObject
    {
        public static void TestCustomObject()
        {

            List<Person> people = new List<Person>
            {
                new Person("Baker", 20),
                new Person("Sander", 25),
                new Person("Vini", 31),
                new Person("Perira", 31)

            };


            Console.WriteLine("Current State of The people List : ");
            foreach (var item in people)
            {
                Console.WriteLine($"Name : {item.Name}, Age : {item.Age}\n");
            }


            // Find Methode 

            Person FoundPerson = people.Find(p => p.Name == "Sander");
            if (FoundPerson != null)
            {
                Console.WriteLine($"\nFound Person : \n\tName : {FoundPerson.Name}, Age : {FoundPerson.Age}\n ");
            }


            // Finiding And Updating the age and name of person

            Person searchResult = people.FirstOrDefault(p => p.Name == "Perira");
            if (searchResult != null)
            {
                searchResult.Age = 21;
                Console.WriteLine($"\nUpdate Perira Age to {searchResult.Age}\n");
            }

            // find All people over than 30

            var PeopleOver30 = people.FindAll(p => p.Age >= 30);
            Console.WriteLine("\nPeople Over Than 30 : ");
            foreach (var item in PeopleOver30)
            {
                Console.Write($"{item.Name} \t");
            }


            // using any to check by name

            bool IsContainsBaker = people.Any(p => p.Name == "Baker");
            Console.WriteLine($"\nList is Contain a person named Baker ?? {IsContainsBaker}\n");


            // Remove people under than 30 

            people.RemoveAll(p => p.Age >= 30);

            Console.WriteLine("After Removing people Under the age of 30 : \n");
            foreach (var item in people)
            {
                Console.WriteLine($"Name : {item.Name}, Age : {item.Age}\n");
            }


        }




    }
}
