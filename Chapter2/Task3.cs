using System;

//Write a program, which compares correctly two real numbers with accuracy at least 0.000001.

namespace MyApp
{
    class Task3
    {
        static void Main(string[] args)
        {
            decimal f = 8923.1225511m;
            decimal g = 8923.12255111222222222111m;
            if (Decimal.Round(f, 7) == Decimal.Round(g, 7))
            {

                Console.WriteLine("Both numbers are equal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Numbers are NOT equal");
                Console.ReadLine();
            }


        }
    }
}
