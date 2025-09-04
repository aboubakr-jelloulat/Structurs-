using System;
using System.Collections.Generic;
using System.Collections;


namespace MyHashTable
{
    // Non-Generic: stores items as object → needs casting, slower (boxing/unboxing), not type-safe.
    // Generic: strongly typed → no casting, faster, type-safe (compile-time checks).



    // A hash table is a data structure that you can use to store data in key-value format with direct access to its items in constant time.


    // A Hashtable in C# is a collection that stores key-value pairs, organized based on the hash code of the key. It resides in the System.Collections 



    //Key Features

    //    Non-Generic       : Operates on objects of any type, requiring casting when retrieving elements.
    //    Efficient Lookups : Utilizes hash codes for keys, optimizing search operations.
    //    Uniqueness        : Keys must be unique, though values may repeat.
    //    Order             : Does not maintain a predictable order of stored elements.


    public class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();

            // Add key-value pairs
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add("four", 4); // Keys and values can be any object type


            // Access a value by key

            Console.WriteLine(ht[2]); 
            Console.WriteLine(ht["four"]);

            // Check if a key exists
            if (ht.ContainsKey(3))
                Console.WriteLine("Key 3 exists!\n");

            // update 
            ht[1] = "Hej !";


            // Iterate through the Hashtable
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }


            // Remove a key
            ht.Remove("four");
            Console.WriteLine("After removing key four:");

            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }


        }
    }
}
