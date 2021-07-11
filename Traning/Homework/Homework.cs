using System;
using System.Collections.Generic;
using System.Text;

namespace Traning.Homework
{
    class Homework
    {
        public class ValueTypesVsReferenseTypes
        {
            public static void Run()
            {
                int a = 7;
                int b = a;

                Console.WriteLine($"Original a value: {a}");
                Console.WriteLine($"Original a value: {b}");

                a = 9;

                Console.WriteLine($"a after notification: {a}");
                Console.WriteLine($"a after notification: {b}");

            }
        }

    }
}