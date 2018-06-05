using System;

namespace ConsoleApp1
{
    class Task3
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hi, please enter an integer number with no less than three digits which you want to verify:");
            int number = Int32.Parse(Console.ReadLine());

            int number2 = number / 100;
            
            if (number2 % 10 == 7)
            {
                Console.WriteLine("Your number HAS 7 as third digit(from right to left)");
            }
            else {
                Console.WriteLine("Your number HAS NOT 7 as third digit(from right to left)");
            }
            Console.ReadKey();
        }
    }
 }

//Write an expression that checks for a given integer if its third digit (right to left) is 7.