using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestApp
{
    class MyException : Exception
    {
        public void InvalidDateException() 
        {
            Console.WriteLine("Invalid date format");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter today's date:");
            input = Console.ReadLine();

            string pattern = @"[0-9]{2} [a-z]{3} [0-9]{4}";
            Regex rgx = new Regex(pattern);

            try
            {
                if (rgx.IsMatch(input))
                {
                    Console.WriteLine("Thanks for telling me");
                }
                else
                {
                    throw new MyException();
                }
            }

            catch (MyException ex) 
            {
                ex.InvalidDateException();
            }



        }
    }
}
