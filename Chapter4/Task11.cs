using System;

namespace ConsoleApp1
{
    class Task11
    {

        static void Main(string[] args)
        {

            decimal first = 0;
            decimal second = 1;
            decimal count = 1;

            Console.WriteLine("#" + count + " = " + first);
            while (count < 100)
            {
                decimal x = first + second;
                first = second;
                second = x;
                count++;


                Console.WriteLine("#" + count + " = " + x);
                
            }
            Console.ReadLine();
        }


    }
 }

//Write a program that prints on the console the first 100 numbers in the 
//Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233