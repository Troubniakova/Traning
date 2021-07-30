using System;
using System.Collections.Generic;
using System.Text;

namespace Traning.Homework
{
    public class BoolTraning
    {
        private const string Question2 = "WHat  you like more 1.Test or 2. Write";
        private static string Answer2;
        public static void Run()
        {
            Console.WriteLine(Question2);
            Answer2 = Console.ReadLine();

            bool isTest = true;
            bool isWrite = true;

            Console.WriteLine(isTest);
            Console.WriteLine(isWrite);

   
            



        }
    }
}
