using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary._01_WorkWithDictionary
{
    internal class Work
    {

        public static void WorkWithDictionary()
        {
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();


            // Adding elements
            fruitBasket.Add("Apple", 5);
            fruitBasket.Add("Banana", 2);

            //the following commented line will casue an error because they key is repeated.

            //fruitBasket.Add("Banana", 5);
            fruitBasket.Add("Orange", 12);


            // Accessing and updating elements
            fruitBasket["Apple"] = 10;


            Console.WriteLine("\nDictionary Content:");

            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }


            // Removing an element
            fruitBasket.Remove("Banana");

            Console.WriteLine("\nDictionary Content after removing Banana:");
            
            foreach (var item in fruitBasket)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }



            Console.WriteLine("\n\nTry Get Value Methode in Dictionnary : \n");

            if (fruitBasket.TryGetValue("Orange", out var value))
            {
                Console.WriteLine($"Orange Quantity is : {value}");
            }
            else
            {
                Console.WriteLine("Not Found in the Basket ");
            }



            // Exception :

            //Console.WriteLine("\n\n Exception : " + fruitBasket["Banana"]);



            Console.WriteLine("\n\nHandell Exception : \n");



            if (fruitBasket.TryGetValue("Banana", out var bananavalue))
            {
                Console.WriteLine($"Banana Quantity is : {bananavalue}");
            }
            else
            {
                Console.WriteLine("Banana Not Found in the Basket ");
            }

        }

    }
}
