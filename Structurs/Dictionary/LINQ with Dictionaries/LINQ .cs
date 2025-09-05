using System;
using System.Collections.Generic;
using System.Linq;


namespace Dictionary.LINQ_with_Dictionaries
{
    public  class clsLINQ
    {

        public static void BasicLINQOperations()
        {
            Dictionary<string, int> basket = new Dictionary<string, int>
            {
                {"Banana", 7},
                {"Apple", 1},
                {"Orange", 3}

            };

            //  **** Selecting Items:

            Console.WriteLine("Selecting Items : \n");

            var basketItems = basket.Select(kpv => new {kpv.Key, kpv.Value});
            foreach (var item in basketItems)
            {
                Console.WriteLine($"Fruit : {item.Key} \tQuantity : {item.Value}");
            }



            // **** Filtering Items

            Console.WriteLine("\n\nFiltering Items : \n");

            var fileredData = basket.Where(kpv => kpv.Value > 3);
            foreach (var item in fileredData)
            {
                Console.WriteLine($"Fruit : {item.Key} \tQuantity : {item.Value}");
            }


            // **** Sorting Dictionary Items

            Console.WriteLine("\n\nSorting Dictionary Items : \n");

            var SortedByQuantity = basket.OrderBy(kvp => kvp.Value);
            foreach (var item in SortedByQuantity)
            {
                Console.WriteLine($"Fruit : {item.Key} \tQuantity : {item.Value}");
            }


            // **** Aggregating Data 

            Console.WriteLine("\n\nAggregating Data : \n");

            var totalQuantity = basket.Sum(kvp => kvp.Value);
            Console.WriteLine($"Total Quantity: {totalQuantity}\n\n");


            var MinValue = basket.Min(kvp => kvp.Value);
            Console.WriteLine($"Min Quantity: {MinValue}");


        }


        public static void AdvancedLINQOperations()
        {
            Dictionary<string, string> fruits = new Dictionary<string, string>
            {
                { "Apple", "Tree" },
                { "Banana", "Herb" },
                { "Cherry", "Tree" },
                { "Strawberry", "Bush" },
                { "Raspberry", "Bush" }
            };

            var groubedFruits = fruits.GroupBy(kvp => kvp.Value);

            foreach (var group in groubedFruits)
            {
                Console.WriteLine($"\nCategory : {group.Key}\n");

                foreach (var fruit in group)
                {
                    Console.WriteLine($"\t-{fruit.Key}");
                }

            }


            // ****  Combining LINQ Queries

            Console.WriteLine("\n\n Combining LINQ Queries : \n");

            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
            {
                { "Apple", 5 },
                { "Banana", 2 },
                { "Orange", 7 }
            };

            var sortedFilteredFruits = fruitBasket.OrderBy(kvp => kvp.Value).Where(kvp => kvp.Value > 3).Select(kpv => new { kpv.Key, kpv.Value });


            Console.WriteLine("\nSorted and Filtered Fruits:\n");
            foreach (var fruit in sortedFilteredFruits)
            {
                Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
            }


        }


        public static void LINQwithDictionaries()
        {
            // BasicLINQOperations();


            AdvancedLINQOperations();

        }
    }
}
