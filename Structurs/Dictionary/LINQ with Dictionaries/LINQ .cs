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

        public static void LINQwithDictionaries()
        {
            BasicLINQOperations();



        }

    }
}
