using List._00_intro;
using List._01_Inserting_Element;
using List._02_Remove;
using List._03_Looping;
using List.Aggregating_Data_Using_LINQ;
using System;
using System.Collections.Generic;

namespace List
{
     /*
        ================================================================================
        What is List<T>?
        --------------------------------------------------------------------------------
        List<T> is a generic collection class in the .NET framework. 
        It is used to store a collection of objects of the same type (T stands for 
        the type parameter). 

        Unlike arrays, List<T> is dynamic, meaning it can automatically resize 
        as needed.

        ================================================================================
        Key Concepts of List<T>
        --------------------------------------------------------------------------------
        1. Generic Collection
           - T in List<T> is a type parameter.
           - You can create a list of any type (e.g., List<int>, List<string>, 
             or List<YourCustomType>).

        2. Dynamic Sizing
           - Automatically resizes itself, offering more flexibility 
             than traditional arrays.

        3. Zero-Based Index
           - Like arrays, lists use zero-based indexing.

        4. Strongly Typed
           - Ensures type safety.
           - Example: You cannot add an int to a List<string>.

        ================================================================================
        Capacity vs Count
        --------------------------------------------------------------------------------
        - Count:    The number of elements actually in the List.
        - Capacity: The number of elements the List can store before resizing.

        ================================================================================
        Thread Safety
        --------------------------------------------------------------------------------
        - List<T> is NOT thread-safe.
        - For thread-safe collections, consider using:
          System.Collections.Concurrent (e.g., ConcurrentBag<T>, ConcurrentQueue<T>).

        ================================================================================
        Conclusion
        --------------------------------------------------------------------------------
        List<T> in C# is a versatile and powerful collection class, suitable 
        for a wide range of applications. 

        Its dynamic nature, coupled with the powerful features provided by 
        the .NET framework, makes it a go-to choice for storing and manipulating 
        collections of objects.
        ================================================================================
        */


    internal class Program
    {
        static void Main(string[] args)
        {

            // **********  [    Intro    ]   **********


            //Intro.TestIntro();



            // **********  [    Insert    ]   **********



            //Insert.TestInsert();



            // **********  [    Remove    ]   **********



            //Remove.TestRemove();



            // **********  [    Looping    ]   **********


            //Looping.TestLooping();



            // **********  [    Aggregating Data Using LINQ    ]   **********


            Aggregating.TestAggregatingData();




            Console.ReadKey();

        }
    }
}
