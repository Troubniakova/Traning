using System;


namespace Traning.ArrayzHW
{
   public  class ArrayzHW2
    {
        public static void Run ()
        {
            Console.WriteLine("\nPlease enter 6 digits number");
            var readNumbers = Console.ReadLine();

            bool isIntegerType = int.TryParse(readNumbers, out var numbers);

            //There is also possibility to combine it in one if. I just decided to separate each message
            if (string.IsNullOrEmpty(readNumbers))
            {
                Console.WriteLine("Value should not be null or empty");
                return;
            }
            if (!isIntegerType)
            {
                Console.WriteLine("Value should contain integers only");
                return;
            }
            if (readNumbers.Length != 6)
            {
                Console.WriteLine("Value should have 6 digits length");
                return;
            }

            var individualDigits = new int[6];

            for (int i = 0; i < individualDigits.Length; i++)
            {
                individualDigits[i] = numbers % 10;
                numbers /= 10;
            }

            var firstPart = individualDigits[0] + individualDigits[1] + individualDigits[2];
            var secondPart = individualDigits[3] + individualDigits[4] + individualDigits[5];

            bool isEqual = (firstPart == secondPart);

            Console.WriteLine(isEqual ? $"{readNumbers} is lucky number)))" : $"{readNumbers} is not lucky number(((");




            //int[] numbers = new int[6];

            //numbers[0] = 1;
            //numbers[1] = 3;
            //numbers[3] = 5;
            //numbers[4] = 10;
            //numbers[5] = 17;

            //int getSum(int numbers)
            //{
            //    int sum = 0;
            //    while (numbers != 0)
            //    {
            //        sum = sum + numbers % 10;
            //        numbers = numbers / 10;
            //    }
            //    return sum;

            //    Console.WriteLine("sum of ");
            //}


            //bool isLucky(int n)
            //{
            //    int counter = 2;

            //    if (counter > n)
            //        return 1;
            //    if (n % counter == 0)
            //        return 0;
            //    counter++;
            //    return isLucky(next_position);
        }



        }
    }

