using System;
using System.Linq;
using System.Collections.Generic;


namespace Hashset.Work_With_HashSet
{
    public class Work
    {

        static void Contains(HashSet<string> greetings)
        {

            
            Console.WriteLine((greetings.Contains("Hej")) ? "Yes is Found" : "Not found");

            Console.WriteLine((greetings.Contains("Salut")) ? "\nYes is Found" : "\nNot found");

        }

        static void Remove(HashSet<string> greetings)
        {

            Console.WriteLine($"HashSet Items Count : {greetings.Count}");


            greetings.Remove("Hola");
            greetings.Remove("Hello");

            Console.WriteLine("\n After Remove Hola & Hello");
            foreach (var item in greetings)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nClear All Item");
            greetings.Clear();
            Console.WriteLine($"HashSet Items Count After Clear : {greetings.Count}");

        }

        public static void RemoveDuplicateFromArrayUsingHashSet()
        {
            int[] numbers = new int[] { 10, 13, 37, 10, 19, 42, 19, 10, 19 };

            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            // Displaying the unique elements
            foreach (var item in uniqueNumbers)
            {
                Console.WriteLine(item);
            }


        }


        public static void WorkWithHasSet()
        {
            HashSet<string> greetings = new HashSet<string>
            {
                "Salam Alaikum",
                "Hello",
                "Hej",
                "Bonjour",
                "Hola",
                "Ciao"
                
            };
            greetings.Add("nǐ hǎo");



            //Contains(greetings);

            //Remove(greetings);


            RemoveDuplicateFromArrayUsingHashSet();

        }


        public static void UsingHashSetWithLinq()
        {
            HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 10, 12, 14 };



            Console.WriteLine("\nEven Numbers : \n");
            var evenNumber = numbers.Where(n => n%2 == 0);

            foreach (var item in evenNumber)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("\nNumbers Greater Than 5:\n");
            var numbersGreaterThanFive = numbers.Where(n => n > 5);

            foreach (var number in numbersGreaterThanFive)
            {
                Console.WriteLine(number);
            }



            HashSet<string> Names = new HashSet<string>
            {
                "Sander",
                "Baker",
                "Vini",
                "Ayoub",
                "Alica",
                "Boss",
                "Moha"
            };

            Console.WriteLine("\nNames Starting with B:\n");
            var namesStartWithB = Names.Where(name => name.StartsWith("B"));

            foreach (var name in namesStartWithB)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("\nNames Longer Than 5 Characters:\n");
            var namesLongerThan5Char = Names.Where(name => name.Length < 5);

            foreach (var name in namesLongerThan5Char)
            {
                Console.WriteLine(name);
            }

        }

    }
}
