using System;

namespace ConsoleApp2
/*Write a program that finds the biggest of three integers, using nested if statements.*/
{
    class Task3
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hi, please enter three integer numbers (each in new line):");
            string[] answer = new string[3];
            int[] arr = new int[answer.Length];
            int value;
            for (int i = 0; i < answer.Length; i++)
            {
                
                    answer[i] = Console.ReadLine();
                if (int.TryParse(answer[i], out value))
                {
                    arr[i] = value;
                    if (i == answer.Length - 1)
                    {
                        if ((arr[0] > arr[1]) && (arr[0] > arr[2]))
                        {

                            Console.WriteLine($"{arr[0]} is the biggest entered number");
                        }

                        else
                        {
                            if ((arr[1] > arr[0]) && (arr[1] > arr[2]))
                            {

                                Console.WriteLine($"{arr[1]} is the biggest entered number");
                            }
                            else
                            {

                                Console.WriteLine($"{arr[2]} is the biggest entered number");
                            }

                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Not an integer!");

                }
            }
        }
    }
}

