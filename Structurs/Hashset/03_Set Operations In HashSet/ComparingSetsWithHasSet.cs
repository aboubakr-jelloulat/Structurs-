using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset._03_Set_Operations_In_HashSet
{
    internal class ComparingSetsWithHasSet
    {

        /// <summary>
        /// if two HashSet instance contain the same elements
        /// </summary>
        static void UsingSetEqual()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set3 = new HashSet<int> { 3, 4, 5 };


            Console.WriteLine("set1 equals set2: " + set1.SetEquals(set2));
            Console.WriteLine("set1 equals set3: " + set1.SetEquals(set3));

        }

        /// <summary>
        /// check if a HashSet is a subset of another collection
        /// </summary>
        static void UsingIsSubsetOf()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("set1 is a subset of set2: " + set1.IsSubsetOf(set2));
            Console.WriteLine("set2 is a subset of set1: " + set2.IsSubsetOf(set1)); // false set2 big than 1

        }

        /// <summary>
        /// if HashSet is super of another collection 
        /// </summary>
        static void IsSupersetOf()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int> { 2, 3 };


            Console.WriteLine($"set1 is a superset of set2: {set1.IsSupersetOf(set2)}" );

        }

        /// <summary>
        /// if two HasSet instance share any common elements
        /// </summary>
        static void UsingOverlaps()
        {

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
            HashSet<int> set3 = new HashSet<int> { 6, 7, 8 };


            Console.WriteLine("set1 overlaps set2: " + set1.Overlaps(set2));
            Console.WriteLine("set1 overlaps set3: " + set1.Overlaps(set3));

        }
        public static void TestComparingSetsWithHasSet()
        {
            //UsingSetEqual();

            //UsingIsSubsetOf();

            //IsSupersetOf();


            UsingOverlaps();

        }


    }
}
