using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List._00_intro
{
    public class Intro
    {
        public static void TestIntro()
        {
            List<int> list = new List<int>();

            list.Add(13);
            list.Add(37);
            list.Add(42);
            list.Add(19);


            Console.Write("Elements of List :  ");
            Console.Write(list[0] + " ");
            Console.Write(list[1] + " ");
            Console.Write(list[2] + " ");
            Console.Write(list[3]);


            Console.WriteLine("\n\nAfter update index 3 to 1337 \n");
            list[3] = 1337;

            Console.WriteLine(list[3]);


        }

    }
}
