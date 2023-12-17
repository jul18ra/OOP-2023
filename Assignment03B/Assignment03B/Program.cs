using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment03B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputNewCustomer();
        }

        private static void InputNewCustomer()
        {
            string name = "";
            int age = 0;
            string email = "";

            bool inputIsValid = false;

            Console.WriteLine("Enter full name:");
            name = Console.ReadLine();
            Console.WriteLine("");

            // Asks for age and checks if it is correct
            while (!inputIsValid)
            {
                Console.WriteLine("Enter age:");
                string ageAsString = Console.ReadLine();
                Console.WriteLine("");

                try
                {
                    age = int.Parse(ageAsString);

                    if (age > 0)
                    {
                        inputIsValid = true;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                }
                catch
                {
                    Console.WriteLine("Invalid age\n");

                }
            }

            inputIsValid = false;

            // Asks for email
            while (!inputIsValid)
            {
                Console.WriteLine("Enter email address:");
                email = Console.ReadLine();
                Console.WriteLine("");

                try
                {
                    ValidateEmail(email);
                    inputIsValid = true;
                }
                catch
                {
                    Console.WriteLine("Invalid email\n");
                }
            }

            SaveCustomerInfo(name, age, email);
        }

        // Saves customer info to file
        private static void SaveCustomerInfo(string name, int age, string email)
        {
            string fileName = "customers.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            using (StreamWriter sW = File.AppendText(filePath))
            {
                sW.WriteLine(name);
                sW.WriteLine(age);
                sW.WriteLine($"{email}\n");
            }

            EnterAnotherCustomer(filePath);
        }

        // Asks if the user wants to enter another customer and if not, customers.txt is opened
        private static void EnterAnotherCustomer(string file)
        {
            Console.WriteLine("Enter another customer? y/n");
            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("");
                InputNewCustomer();
            }
            else if (input == "n")
            {
                Process.Start("notepad.exe", file);
            }
            else
            {
                Console.WriteLine("Invalid input\n");
            }
        }

        private static void ValidateEmail(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]+$+";

            Regex rgx = new Regex(pattern);

            if (!rgx.IsMatch(email))
            {
                throw new FormatException();
            }

        }

    }
}
