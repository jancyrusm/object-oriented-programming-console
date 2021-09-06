/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/8/2021
 * Time: 7:15 PM
 * 
 * 2. Write a program that reads the radius r of a circle and prints its perimeter and area.
 */
 
using System;

namespace Number_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radiusCircle = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            double diameterCircle = radiusCircle + radiusCircle;
            double perimeterCircle = (2 * Math.PI) * radiusCircle;
            double areaCircle = Math.PI * Math.Pow(radiusCircle, 2);
            
            Console.WriteLine("The diameter of the circle is {0:0}.", diameterCircle);
            Console.WriteLine();
            
            Console.WriteLine("The perimeter of the circle is {0:0.00000}.", perimeterCircle);
            Console.WriteLine();
            
            
            Console.WriteLine("The area of the circle is {0:0.0000}.", areaCircle);
            Console.WriteLine();
            
            Console.Write("Press 'ENTER' to exit . . . ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
            }
        }
    }
}
