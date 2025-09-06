using System;
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


    }
}
