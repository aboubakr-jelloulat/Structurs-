﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset._05_SortedSet
{
    internal class clsSortedSet
    {

        public static void TestSortedSet()
        {
            SortedSet<int> sortedSet = new SortedSet<int>();


            // Add elements to the SortedSet
            sortedSet.Add(5);
            sortedSet.Add(2);
            sortedSet.Add(2);
            sortedSet.Add(8);
            sortedSet.Add(3);
            sortedSet.Add(2);


            // Display the elements of the SortedSet
            Console.WriteLine("SortedSet elements:");
            foreach (int element in sortedSet)
            {
                Console.WriteLine(element);
            }


            // Check if an element exists in the SortedSet
            int target = 3;
            if (sortedSet.Contains(target))
            {
                Console.WriteLine($"Element {target} exists in the SortedSet.");
            }


            // Remove an element from the SortedSet
            sortedSet.Remove(2);


            // Display the elements of the SortedSet after removal
            Console.WriteLine("SortedSet elements after removal:");
            foreach (int element in sortedSet)
            {
                Console.WriteLine(element);
            }

        }

    }
}
