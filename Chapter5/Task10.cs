using System;

namespace ConsoleApp2
/*Write a program that applies bonus points to given scores in the range [1…9] by the following rules:

-     If the score is between 1 and 3, the program multiplies it by 10.

-     If the score is between 4 and 6, the program multiplies it by 100.

-     If the score is between 7 and 9, the program multiplies it by 1000.

-     If the score is 0 or more than 9, the program prints an error message.*/
{
    class Task10
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please enter your score(1-9) to calculate bonus points:");
            int value = 0;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out value))
            {
                Console.WriteLine($"{input} is not an integer!!! What is wrong with you man?");
                
            }
                       
            switch (value)

            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"Now your score is {value*10}");
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"Now your score is {value * 100}");
                    break;

                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"Now your score is {value * 1000}");
                    break;


                default:
                    Console.WriteLine("The score, should be in range 1-9!");
                    break;

            }
        }
    }
}

