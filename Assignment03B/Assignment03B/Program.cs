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

        private static void SaveCustomerInfo(string name, int age, string email)
        {
            string fileName = @"\customers.txt";
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;

            using (StreamWriter sW = File.AppendText(filePath))
            {
                sW.WriteLine(name);
                sW.WriteLine(age);
                sW.WriteLine($"{email}\n");
            }

            EnterAnotherCustomer(filePath);
        }

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
