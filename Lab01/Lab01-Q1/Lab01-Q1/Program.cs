using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.	Write a Console Application Program to calculate the area of a rectangle. 
             * Prompt the user to enter the length and width. 
             * Display the calculated area. (use a separate function calculate the area).*/

            double Area, Length, Width;

            //Get user input
            Console.WriteLine("Enter the Length of the Rectangle:");
            Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width of the Rectangle");
            Width = double.Parse(Console.ReadLine());

            //calculate and display area
            Area = CalculateArea(Length, Width);
            Console.WriteLine("Area of Rectangle: " + Area);

            Console.ReadLine();

        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
}
