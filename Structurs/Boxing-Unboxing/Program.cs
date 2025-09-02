using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    public class Program
    {
        public static void Boxing()
        {
            //Boxing is the process of converting a value type to a reference type.This involves wrapping a value type(like int, float, char)
            //in an object or any interface type implemented by this value type.



            // Boxing is the process of taking a value type that’s stored on the stack and wrapping it inside an object on the heap.


            int     value = 42;     
            object obj = value;      // Boxing: a new object is created on the heap containing 42

            Console.WriteLine("Value : {0}", value);
            Console.WriteLine("Objtec : {0}", obj);


        }


        public static void Unboxing()
        {
            int value = 123;          // Value type on stack
            object boxedValue = value; // Boxing: copy of value stored on heap

            // Unboxing: extract value from heap object back to stack
            int unboxedValue = (int)boxedValue;

            Console.WriteLine($"Original value: {value}");
            Console.WriteLine($"Boxed object: {boxedValue}");
            Console.WriteLine($"Unboxed value: {unboxedValue}");
        }



        static void Main(string[] args)
        {

            //Boxing();

            //Unboxing();
        }
    }
}

