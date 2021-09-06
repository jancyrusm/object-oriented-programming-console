/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/8/2021
 * Time: 8:45 PM
 * 
 * 4. Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. 
 */
 
using System;

namespace Number_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int unangNumero = Int32.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int ikalawangNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int counter = 0;
            
            for (int a = unangNumero; a <= ikalawangNumero; a++) {
                if (a % 5 == 0) {
                counter++;
                }
            }
            
            Console.WriteLine("p({0},{1}) = {2} ", unangNumero, ikalawangNumero, counter);
            Console.WriteLine();
            
            Console.Write("Press 'ENTER' to exit . . . ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
            }
        }
    }
}
