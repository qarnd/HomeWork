using System;

namespace ConsoleApp1
{
    class Task2
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hi, please enter an integer number which you want to verify:");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Your number CAN be devided by 5 and 7 without a rest");
            }
            else {
                Console.WriteLine("Your number CANNOT be devided by 5 and 7 without a rest");
            }
            Console.ReadKey();
        }
    }
 }

//Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.