using System;
using System.Collections.Generic;
using System.Text;

namespace Traning.ArrayzHW
{
    public class Caclulator
    {
        public static void SumCalculator()
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int oddNumberSum = 0;
            int evenNumberSum = 0;


            Console.WriteLine("Write first number");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Write last number");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumberSum += currentValue;
                }
                else
                {
                    
                    oddNumbersCount++;
                    oddNumberSum += currentValue;
                }
                currentValue++;
            }

            Console.WriteLine("Amount of oddNumbers " + oddNumbersCount);
            Console.WriteLine("Amount of evenNumbers " + evenNumbersCount);
            Console.WriteLine("Sum of oddNumbers " + oddNumberSum);
            Console.WriteLine("Sum of evenNumbers " + evenNumberSum);
            Console.ReadLine();

            
        }



        }
    }

