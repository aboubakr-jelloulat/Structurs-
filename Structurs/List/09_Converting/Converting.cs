using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List._09_Converting
{
    public class Converting
    {

        public static void ConvertingArrayToList()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            List<int> list = new List<int> (numbers);


            Console.WriteLine("List Elements : " + string.Join(", ", list));

        }


        public static void ConvertingListToArray()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            // Converting  List  To Array

            int[] numbersArray = list.ToArray();

            Console.WriteLine($"Array Elements : {string.Join(", ", numbersArray)}");


        }

    }
}
