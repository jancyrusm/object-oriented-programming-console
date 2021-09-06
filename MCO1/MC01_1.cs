/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/8/2021
 * Time: 7:15 PM
 * 
 * 1. Write a program that reads 3 integer numbers from the console and prints their sum.
 */
 
using System;

namespace Number_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int unangNumero = Int32.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int ikalawangNumero = Int32.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int ikatlongNumero = Int32.Parse(Console.ReadLine());
            
            int sum = unangNumero + ikalawangNumero + ikatlongNumero;
            Console.Write("The sum of the three numbers is {0}", sum);
            
            //End
            
            Console.Write("Press 'ENTER' to exit . . . ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
            }
        }
    }
}
