using System;

namespace ConsoleApp1
{
    class Task1
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hi, please enter an integer number which you want to verify:");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else if (number % 2 > 0)
            {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadKey();
        }
    }
 }

//Write an expression that checks whether an integer is odd or even.