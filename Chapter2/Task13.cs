using System;
using System.Collections.Generic;
using System.Text;

//Declare two variables of type int. Assign to them values 5 and 10 respectively.Exchange(swap) their values and print them.

namespace MyApp
{
    class Task13
    {
        static void Main(string[] args)
        {
            int f = 5;
            int g = 10;
            int c = f;

            f = g;
            g = c;

            Console.WriteLine($"First was 5 and now {f}, and Second was 10 but now {g}");
            Console.ReadLine();
        }
    }
}
