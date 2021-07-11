using System;
using Traning.second_lesson;

namespace Traning
{
    public class Program
    {
        private const string Question = "Hello! What is your name?";
        private const string Question2 = "How old are you?";
        private const string Greeting = "Hello ";

        private static string Answer;
        private static string Answer2;

        public static void Main(string[] args)
        {
            Console.WriteLine(Question);

            Answer = Console.ReadLine();

            Console.WriteLine(Question2);
            Answer2 = Console.ReadLine();

            int age = int.Parse(Answer2);
            if (age > 0 && age < 99)
                {
                if (age < 7)
                {
                    Console.WriteLine(Greeting + Answer + "Pass is restricted");
                }
                else if (int.Parse(Answer2) < 12)
                {
                    Console.WriteLine(Greeting + Answer + "Please, go. You have a discount");

                }
                else
                {
                    Console.WriteLine(Greeting + Answer + "Please, go and enjoy");
                }

                

                Console.ReadLine();

            }
        }
             
    }
}
