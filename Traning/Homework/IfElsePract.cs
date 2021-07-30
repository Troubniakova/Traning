using System;
using System.Collections.Generic;
using System.Text;

namespace Traning.Homework
{
   public class IfElsePract
    {
        private const string Question1 = "WHat Product you want to choose from 1 to 10 ?";
        private static string Answer1;
        private static string Answer2;
       
        public static void Run()
        {
            Console.WriteLine(Question1);
            Answer1 = Console.ReadLine();
            Console.WriteLine(Question1);
            Answer2 = Console.ReadLine();

            int Product = int.Parse(Answer1);
            

            if (Product > 1 && Product < 10)
            {
                if(Product < 5)
                    Console.WriteLine("You selected the product less then 5!");
            }
             else if (int.Parse(Answer2) >5)
            {
                Console.WriteLine(Answer2 + "Please, go. You have a discount");
            }

            Console.ReadLine();
        }
    }
}
