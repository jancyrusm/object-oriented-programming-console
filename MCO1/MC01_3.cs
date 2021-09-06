/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/8/2021
 * Time: 7:38 PM
 * 
 * 3. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console. 
 */
using System;

namespace Number_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Company Details: ");
            Console.WriteLine();
            
            Console.Write("Please state the name of the company: ");
            string companyName = Console.ReadLine();
    
            Console.Write("Please state the company address: ");
            string companyAddress = Console.ReadLine();
            
            Console.Write("Please enter the company phone number: ");
            string phoneNumber = Console.ReadLine();
            
            Console.Write("Please enter the company fax number: ");
            string faxNumber = Console.ReadLine();

            Console.Write("Please enter the address of the company website: ");
            string companyWebsite = Console.ReadLine();    

            Console.Write("Please state the name of the company manager: ");
            string companyManager = Console.ReadLine();
            Console.WriteLine();            

            Console.Write("Manager Information: ");
            Console.WriteLine();
            
            Console.Write("Please state the first name of the company manager: ");
            string managerFirstname = Console.ReadLine();    
 
            Console.Write("Please state the last name of the company manager: ");
            string managerLastname = Console.ReadLine();
            
            Console.Write("Please enter the age of the company manager: ");
            string managerAge = Console.ReadLine();
            
            Console.Write("Please enter the phone number of the company manager: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();        
            
            Console.WriteLine("==============================================");
            Console.WriteLine("\t Company Details: ");
            Console.WriteLine("==============================================");
            Console.WriteLine(" {0} : {1}", "Company Name", companyName);
            Console.WriteLine(" {0} : {1}", "Company Address", companyAddress);
            Console.WriteLine(" {0} : {1}", "Company Phone Number", phoneNumber);
            Console.WriteLine(" {0} : {1}", "Company Fax Number", faxNumber);
            Console.WriteLine(" {0} : {1}", "Company Website", companyWebsite);
            Console.WriteLine(" {0} : {1}", "Company Manager", companyManager);
            Console.WriteLine("==============================================");
            Console.WriteLine();
            
            Console.WriteLine("==============================================");
            Console.WriteLine("\t Manager Information: ");
            Console.WriteLine("==============================================");
            Console.WriteLine(" {0} : {1}", "First Name", managerFirstname);
            Console.WriteLine(" {0} : {1}", "Last Name", managerLastname);
            Console.WriteLine(" {0} : {1}", "Age", managerAge);
            Console.WriteLine(" {0} : {1}", "Phone Number", managerPhone);
            Console.WriteLine("==============================================");
            Console.WriteLine();
        
            // End
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
