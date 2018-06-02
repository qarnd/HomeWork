using System;
using System.Collections.Generic;
using System.Text;

/*Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” 
 * (without the outer quotes). In one of the variables use quoted string and in the other do not use it.*/

namespace MyApp
{
    class Task9
    {
        static void Main(string[] args)
        {

            string a = "The \"use\" of quotations causes difficulties.";
            string b = "The use of quotations causes difficulties.";

            Console.WriteLine(a + " " + b);
            Console.ReadLine();





        }
    }
}
