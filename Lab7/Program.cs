using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a name under the following conditions: \n" +
                "- Name must contain only letters \n" +
                "- Name must start with a capital letter \n" +
                "- Maximum length of 30 characters \n");
            string name = Console.ReadLine();
            Console.WriteLine("\n");

            Regex namePattern = new Regex(@"[A-Z]{1}\w{1,29}");
            if (namePattern.IsMatch(name))
            {
                Console.WriteLine("Name accepted \n");
            }
            else
            {
                Console.WriteLine("Name not accepted please re-enter \n");
            }


            Console.WriteLine("Enter an email address under the following conditions: \n" +
                "- Email and domain can contain letters and numbers, no special characters \n" +
                "- Email has min/max length of 5-30 characters, domain has a min/max length of 5-10 characters \n");
            string email = Console.ReadLine();
            Console.WriteLine("\n");
            Regex emailPattern = new Regex(@"(\w[A-z\d]{5,30})@(\w[A-z\d]{5,10})\.(com|edu|net|gov)");

            if (emailPattern.IsMatch(email))
            {
                Console.WriteLine("Email accepted \n");
            }
            else
            {
                Console.WriteLine("Email not accepted please re-enter \n");

            }


            Console.WriteLine("Enter a phone number under the following format: 111-111-1111 \n");
            string phone = Console.ReadLine();
            Console.WriteLine("\n");
            Regex phonePattern = new Regex(@"^(\d{3}-\d{3}-\d{4})$");

            if(phonePattern.IsMatch(phone))
            {
                Console.WriteLine("Phone number accepted \n");
            }
            else
            {
                Console.WriteLine("Phone number not accepted please re-enter");
            }

            
            Console.WriteLine("Enter a dater under the following format: dd/mm/yyyy \n");
            string date = Console.ReadLine();
            Console.WriteLine("\n");
            Regex datePattern = new Regex(@"^(\d{2}\/\d{2}\/\d{4})$");

            if (datePattern.IsMatch(date))
            {
                Console.WriteLine("Date accepted \n");
            }
            else
            {
                Console.WriteLine("Date not accepted please re-enter");
            }
        }  
    }
}
