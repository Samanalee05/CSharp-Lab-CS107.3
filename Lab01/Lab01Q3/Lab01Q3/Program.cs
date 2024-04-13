using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3.	Write a Console Application program to calculate the sum of all numbers 
                    from 1 to a given positive integer. 
                    Prompt the user to enter a positive integer and display the sum. 
                    If the user inputs a negative value it should display “ERROR”. */

            Console.WriteLine("Please enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Check if positive integer
            if (num > 0)
            {
                int sum = 0;
                for (int i=1; i <= num; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"The sum of numbers from 1 to {num} is: {sum}");
            }
            else
            {
                Console.WriteLine("ERROR: Please enter a positive integer.");
            }

            Console.ReadLine();
        }
    }
}
