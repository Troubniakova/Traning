using System;
using System.Collections.Generic;
using System.Text;

namespace Traning.Loops
{
    public class LoopPract
    {
        public static void Run()
        {
            int[] arrayOfIntegers = new int[5];

            arrayOfIntegers[0] = 5;
            arrayOfIntegers[1] = 7;
            arrayOfIntegers[4] = 10;
            arrayOfIntegers[4] = 9;

            int[] arrayOfIntegers2 = new int[10]; //Init an array with 10 elements.Each of them are equal to 0

            Console.WriteLine();
            for (int i = 0; i < arrayOfIntegers2.Length; i++)
            {
                Console.WriteLine($"arrayOfIntegers2 element {i} is equal to {arrayOfIntegers2[i]} ");
            }

            Console.WriteLine();
            for (int i = arrayOfIntegers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"arrayOfIntegers2 element {i} is equal to {arrayOfIntegers[i]} ");
            }

            int[] arrayOfIntegers3 = new int[20];
            for (int a = 0; a < arrayOfIntegers3.Length; a++)
            {
                arrayOfIntegers3[a] = a;
                Console.WriteLine($"arrayOfIntegers3 element {a} is equal to {a}");
            }

            //int[] arrayOfIntegers3 = new int[20];
            //for (int a = 0; a < arrayOfIntegers3.Length; a++)
            //{
            //    arrayOfIntegers3[a] = a + 1;
            //    Console.WriteLine($"arrayOfIntegers3 element {a} is equal to {arrayOfIntegers3[a]}");
            //}
        }


    }
}
