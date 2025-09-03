using System;
using System.Collections.Generic;
using System.Linq;


namespace List.Aggregating_Data_Using_LINQ
{
    internal class Aggregating
    {
            

        public static void TestAggregatingData()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7};

            Console.WriteLine($"Count = {numbers.Count()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Average = {numbers.Average()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");

        }
    }
}
