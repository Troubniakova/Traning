using System;
using System.Collections.Generic;
using System.Text;

namespace Traning.Erase
{
    public class SingleArrays
    {
        public static void Run()
        {
            //Declaration and initialization
            int[] arrayOfIntegers = new int[5];

            arrayOfIntegers[0] = 5;
            arrayOfIntegers[1] = 7;
            arrayOfIntegers[4] = 10;
            arrayOfIntegers[4] = 9;

            Console.WriteLine("arrayOfIntegers length is " + arrayOfIntegers.Length);
            Console.WriteLine("arrayOfIntegers last element is " + arrayOfIntegers[arrayOfIntegers.Length - 1]);
            Console.WriteLine("arrayOfIntegers third element is " + arrayOfIntegers[2]);


            



            //Declaration, initialization and assignment (With array length)
            string[] arrayOfStrings = new string[2] { "Testing", "Development" };

            //Declaration, initialization and assignment (Without array length. It will be created automatically)
            bool[] arrayOfBooleans = new[] { true, false, false, true };


            
        }
       

    }
}
