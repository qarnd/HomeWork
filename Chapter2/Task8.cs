using System;
using System.Collections.Generic;
using System.Text;

/*Declare two variables of type string and assign them values "Hello" and "World". Declare a variable of type object 
 * and assign to it the value obtained of concatenation of the two variables of type string (do not miss the space in the middle). 
 * Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).*/

namespace MyApp
{
    class Task8
    {
        static void Main(string[] args)
        {

            string a = "Hello";
            string b = "World";
            object word = a + " " + b;

            string c = Convert.ToString(word);
            Console.WriteLine(c);
            Console.ReadLine();





        }
    }
}
