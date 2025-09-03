using System;
using System.Collections.Generic;
using System.Linq;


namespace List.Filtering_Data_with_LINQ
{
    internal class Filtering
    {
        
        public static void TestFiltering()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            Console.WriteLine("Even Numbers     : " + string.Join(", ", numbers.Where(n => n % 2 == 0)));
            Console.WriteLine("ODD Numbers      : " + string.Join(", ", numbers.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers grater than 5  : " + string.Join(", ", numbers.Where(n => n >= 5)));
            Console.WriteLine("Every Second Numbers   : " + string.Join(", ", numbers.Where((n, index) => index % 2 == 0)));
            Console.WriteLine("Numbers Between 3 & 8  : " + string.Join(", ", numbers.Where(n => n > 3 && n < 8)));



        }


    }
}
