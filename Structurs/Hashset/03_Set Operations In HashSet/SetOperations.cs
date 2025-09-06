using System;
using System.Collections.Generic;
using System.Linq;


namespace Hashset._03_Set_Operations_In_HashSet
{
    internal class SetOperations
    {

        static void UnionOperationWithHashSet()
        {
            HashSet<int> set1 = new HashSet<int> { 13, 42, 37 };
            HashSet<int> set2 = new HashSet<int> { 13, 42, 19 };


            set1.UnionWith(set2);
            Console.WriteLine("Union of sets:\n");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }

        }


        static void IntersectionOperationWithHashSet()
        {

            // ** Understand finding common elements between two sets using IntersectWith

            HashSet<int> set1 = new HashSet<int> { 13, 37, 42 };
            HashSet<int> set2 = new HashSet<int> { 14, 19, 42 };

            set1.IntersectWith(set2);

            Console.WriteLine("Intersection of sets:\n");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }

            //  The output is 42, the only common element between the two sets. IntersectWith retains only those elements that are present in both sets.

        }

        static void DifferenceOperationWithHashSet()
        {
            HashSet<int> set1 = new HashSet<int> { 13, 14, 19, 37, 42 };
            HashSet<int> set2 = new HashSet<int> {14, 19, 42 };

            set1.ExceptWith(set2);

            Console.WriteLine("Difference of sets (set1 - set2):\n");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }

            // Remove 14 and 19 and 42 because is fond in set2 

        }

        static void SymmetricDifferenceOperationWithHashSet()
        {
            HashSet<int> set1 = new HashSet<int> { 13, 37, 20};
            HashSet<int> set2 = new HashSet<int> { 20, 42, 19 };


            // like (set1 - set2) union (set2 - set1)

            set1.SymmetricExceptWith(set2); // Remove the duplicate in the two sets remove 20 

            Console.WriteLine("Symmetric difference of sets: \n");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }

        }


        public static void TestSetOperations()
        {

            UnionOperationWithHashSet();


            IntersectionOperationWithHashSet();



            DifferenceOperationWithHashSet();


            SymmetricDifferenceOperationWithHashSet();

        }
    }
}
