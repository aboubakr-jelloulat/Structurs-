using System;
using System.Collections.Generic;


namespace List._03_Looping
{
    public class Looping
    {


        public static void TestLooping()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Number of items in the list: " + numbers.Count);


            Console.WriteLine("\nDisplaying list elements using a for loop:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]); // Accessing each element by its index
            }


            Console.WriteLine("\nDisplaying list elements using a foreach loop:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // Accessing each element directly
            }


            // Looping through the list using the List.ForEach method
            Console.WriteLine("\nDisplaying list elements using List.ForEach: + Action = lambda expression");
            numbers.ForEach(number => Console.WriteLine(number)); // Using a lambda expression

        }

    }
}
