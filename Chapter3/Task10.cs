using System;

namespace ConsoleApp1
/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:

-     Calculates the sum of the digits (in our example 2+0+1+1 = 4).

-     Prints on the console the number in reversed order: dcba (in our example 1102).

-     Puts the last digit in the first position: dabc (in our example 1201).

-     Exchanges the second and the third digits: acbd (in our example 2101).*/
{
    class Task10
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hi, please enter an integer number with 4 digits which you want to verify:");
            int number = Int32.Parse(Console.ReadLine());

            int a = number % 10;
            int b = (number / 10) % 10;
            int c = (number / 100) % 10;
            int d = (number / 1000) % 10;

            int sum = a + b + c + d;
            Console.WriteLine("1. Sum of the digits is equal: " + sum);
            Console.WriteLine($"2. Reverse of the digits is equal: {a} {b} {c} {d}");
            Console.WriteLine($"3. When last digit becomes first and vice versa: {a} {c} {b} {d}");
            Console.WriteLine($"2. When second becomes third and vice versa: {d} {b} {c} {a}");

            Console.ReadKey();
        }
    }
 }
