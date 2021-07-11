using System;


namespace Traning.second_lesson
{
    public class BasicCsharrp1
    {
        public static void BasicCsharrpRun()
        {
            string message;

            message = " Have a nice day";

            string message2;

            message2 = "Hello world";

            Console.WriteLine("Hello World!" + message);

            message = " Starting calculation...";

            Console.WriteLine(message);

            Console.WriteLine(Sum(2, 3));

            Console.ReadLine();
        }
        public static int Sum(int value1, int value2)
        {

            return value1 + value2;

        }


    }
            
    }

