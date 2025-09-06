using System;
using System.Collections.Generic;


namespace Hashset.Intro
{
    internal class clsIntro
    {

        public static void intro()
        {
            Console.WriteLine("Objective");
            Console.WriteLine("  Understand what HashSet<T> is and its key characteristics.");
            Console.WriteLine();
            Console.WriteLine("Content");
            Console.WriteLine("  Definition: HashSet<T> is a collection class in the System.Collections.Generic namespace designed to store unique elements.");
            Console.WriteLine("  Uniqueness: The primary feature of HashSet<T> is that it automatically ensures all elements are unique.");
            Console.WriteLine("  HashSet only stores unique values (duplicates are ignored).");
            Console.WriteLine("  No Indexing: Unlike lists, HashSet<T> does not maintain the order of its elements and does not support indexing.");
            Console.WriteLine("  Generic: HashSet<T> is a generic collection, meaning it can store any type of object.");


        }

        public static void declare()
        {
            HashSet<string> hs = new HashSet<string>();

            hs.Add("hello");
            hs.Add("Hola");
            hs.Add("Hej");
            hs.Add("Bonjour");



            // Trying to add a duplicate element
            hs.Add("Hej");
            hs.Add("Hej");
            hs.Add("Bonjour");



            // duplicates are ignored
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }


        }


    }
}
