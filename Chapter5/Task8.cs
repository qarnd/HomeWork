using System;

namespace ConsoleApp2
/*Write a program that, depending on the user’s choice, inputs int, double or string variable. 
 * If the variable is int or double, the program increases it by 1. If the variable is a string,
 * the program appends "*" at the end. Print the result at the console. Use switch statement*/
{
    class Task8
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please enter your value:");
            string value = Console.ReadLine();

            Console.WriteLine("Please enter type of your input by entering numbers 0=integer, 1=double, 2=string:");
            int type = int.Parse(Console.ReadLine());

            switch (type)

            {
                case 0:
                    Console.WriteLine($"Now your value is {int.Parse(value) +1 }");
                    break;

                case 1:
                    Console.WriteLine($"Now your value is {double.Parse(value) + 1 }");
                    break;

                case 2:
                    Console.WriteLine($"Now your value is {value}*");
                    break;


                default:

                    Console.WriteLine("You entered unknown type!");
                    break;

            }
        }
    }
}

