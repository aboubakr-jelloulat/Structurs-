using System;
using System.Collections.Generic;


namespace List._02_Remove
{
    public class Remove
    {

        public static void TestRemove()
        {
            List<int> numbers = new List<int> { 1337, 2, 3, 42, 5, 6, 7, 8, 9, 10 };


            // Removing an item by value
            numbers.Remove(42);
            Console.WriteLine("After removing 42: " + string.Join(", ", numbers));


            // Removing an item by index
            numbers.RemoveAt(0);
            Console.WriteLine("After removing first element: " + string.Join(", ", numbers));


            // Removing multiple items
            numbers.RemoveAll(n => n % 2 == 0);
            Console.WriteLine("After removing all even numbers: " + string.Join(", ", numbers));


            // Clearing the list
            numbers.Clear();
            Console.WriteLine("After clearing the list, count: " + numbers.Count);


        }
    }
}
