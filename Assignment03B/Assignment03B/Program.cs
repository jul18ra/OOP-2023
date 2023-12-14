using System;
using System.Collections.Generic;
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

            while (!inputIsValid)
            {
                Console.WriteLine("Enter age:");

                try
                {
                    age = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Invalid age");
                }
            }

            inputIsValid = false;

            while (!inputIsValid)
            {
                Console.WriteLine("Enter email address:");
                email = Console.ReadLine();

                try
                {
                    ValidateEmail(email);
                    inputIsValid = true;
                }
                catch
                {
                    Console.WriteLine("Invalid email");
                }
            }

            SaveCustomerInfo(name, age, email);
        }

        private static void SaveCustomerInfo(string name, int age, string email)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath += @"\customers.txt";

            using (StreamWriter sW = File.AppendText(filePath))
            {
                sW.WriteLine(name);
                sW.WriteLine(age);
                sW.WriteLine(email);
                // File.Open(filePath, FileMode.Open);
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
