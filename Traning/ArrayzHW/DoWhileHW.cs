using System;
using System.Collections.Generic;
using System.Text;

namespace Traning.ArrayzHW
{
    public class DoWhileHW
    {
        public static void PracticeDoWhile()
        {
            bool isInteger;

            Console.Clear();
            Console.WriteLine("Prints while integer: \n");

            do
            {
                string input = Console.ReadLine();
                isInteger = int.TryParse(input, out var result);

                if (isInteger)
                    Console.WriteLine($"You've entered a new text of integer type {result}");
            }
            while (isInteger);

            Console.WriteLine("It was not an integer");

        }
    }
}
