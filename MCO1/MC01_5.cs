/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/8/2021
 * Time: 8:15 PM
 * 
 * 5. Write a program that gets two numbers from the console and prints the greater of them. Don't use if statements.
 */
 
using System;

namespace Number_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
        
            Console.Write("Please enter the last number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            var resulta = (firstNumber > secondNumber)? "greater" : "less";
            Console.WriteLine("{0} is {1} than {2}.", firstNumber, resulta, secondNumber);
            Console.WriteLine("Therefore, {0} is the greater number.", Math.Max(firstNumber, secondNumber));
            Console.WriteLine();
            
            // End
            
            Console.Write("Press 'ENTER' to exit . . . ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
            }
        }
    }
}
