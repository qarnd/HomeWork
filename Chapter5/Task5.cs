using System;

namespace ConsoleApp2
/*Write a program that asks for a digit (0-9), and depending on the input, 
 * shows the digit as a word (in English). Use a switch statement.*/
{
    class Task5
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hi, please enter integer number from 0 to 9:");
            int number = int.Parse(Console.ReadLine());

            switch (number)

            {
                case 0:
                    Console.WriteLine("You entered ZERO"); break;

                case 1:
                    Console.WriteLine("You entered ONE"); break;

                case 2:
                    Console.WriteLine("You entered TWO"); break;

                case 3:
                    Console.WriteLine("You entered THREE"); break;

                case 4:
                    Console.WriteLine("You entered FOUR"); break;

                case 5:
                    Console.WriteLine("You entered FIVE"); break;

                case 6:
                    Console.WriteLine("You entered SIX"); break;

                case 7:
                    Console.WriteLine("You entered SEVEN"); break;

                case 8:
                    Console.WriteLine("You entered EIGHT"); break;

                case 9:
                    Console.WriteLine("You entered NINE"); break;
                    

                default:

                    Console.WriteLine("You entered unknown number!"); break;

            }
        }
    }
}

