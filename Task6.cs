using System;
using System.Collections.Generic;
using System.Text;

//Declare a variable isMale of type bool and assign a value to it depending on your gender.

namespace MyApp
{
    class Task6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your gender please (Male/Female)");
            string gender = Console.ReadLine();

            if (gender.ToLower() == "male")
            {
                bool isMale = true;
                Console.WriteLine("Does Your gender is Male " + isMale);
            }
            else
            {
                bool isMale = false;
                Console.WriteLine("Does Your gender is Male " + isMale);
            }


        }
    }
}
