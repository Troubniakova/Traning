using System;

namespace Traning.Loops
{
    public class LoopHW
    {
        public static void Run()
        {
            

            int[] arrayOfIntegers = new int[20];
           
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                arrayOfIntegers[i] = i + 1;
                Console.WriteLine($"arrayOfIntegers element {i} is equal to {arrayOfIntegers[i]} ");
            }


            int[] arrayOfIntegers2 = new int[arrayOfIntegers.Length];
            for (int f = arrayOfIntegers.Length - 1; f > -1; f--)
            {
                arrayOfIntegers2[f] = f + 1;

                Console.WriteLine($"ArrayOfInteger2 {f} is equal to {arrayOfIntegers2[f]}");
               
            }

            Console.ReadLine();
        }
    }
}
