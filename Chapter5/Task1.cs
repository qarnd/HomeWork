using System;

/*Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.*/

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integer values:");
            
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
           

            if (number1 > number2)
            {
                number2 = number1;
                Console.WriteLine($"Firts number is bigger than second so Number1 = {number1} and Number2 = {number2} too as it tooks Number1 value");
            }
            else
            {
                Console.WriteLine($"First number is {number1} and it is smaller than second that is equal {number2}, so no exchanges of values was performed");
            }

            
        }
    }
}