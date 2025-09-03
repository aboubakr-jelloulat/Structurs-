using System;
using System.Collections.Generic;
using System.Linq;


namespace List._07_search_and_predicate_methods_
{
    public class predicate_methods
    {

        public static void TestPredicateMethodsWithIntergers()
        {
            List<int> numbers = new List<int> { 44, 22, -55, 666, 9, -6, 345, 11, 3, 3 };


            // Using Contains
            Console.WriteLine("List contains 9: " + numbers.Contains(9));


            // Using Exists
            Console.WriteLine("List contains negative numbers: " + numbers.Exists(n => n < 0));


            // Using Find
            Console.WriteLine("First negative number: " + numbers.Find(n => n < 0));


            // Using FindAll
            Console.WriteLine("All negative numbers: " + string.Join(", ", numbers.FindAll(n => n < 0)));


            // Using Any
            Console.WriteLine("Any numbers greater than 100: " + numbers.Any(n => n > 100));



        }



        public static void TestPredicateMethodsWithStrings()
        {
            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };


            // Using Contains
            Console.WriteLine("List contains 'apple': " + words.Contains("Mechmach"));


            // Using Exists
            Console.WriteLine("List contains a word of length 5: " + words.Exists(word => word.Length == 5));


            // Using Find
            Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));


            // Using FindAll
            Console.WriteLine("Words longer than 5 characters: " + string.Join(", ", words.FindAll(word => word.Length > 5)));


            // Using Any
            Console.WriteLine("Any words starting with 'a': " + words.Any(word => word.StartsWith("a")));


        }

    }
}
