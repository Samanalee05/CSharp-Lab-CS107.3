using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.	Write a Console Application program to check if the given 10 number inputs are even
            //or odd. Prompt the user to enter the numbers, and display whether it's even or odd.


            Console.WriteLine("Please enter 10 numbers: ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                int number = int.Parse(Console.ReadLine());

                //check even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }

            Console.ReadLine();

        }
    }
}
