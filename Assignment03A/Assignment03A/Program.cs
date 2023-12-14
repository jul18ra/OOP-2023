using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment03A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string email;
            int age;
            bool inputIsValid = false;

            Console.WriteLine("Enter full name:");
            name = Console.ReadLine();


            while(!inputIsValid)
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
         
            Console.WriteLine("Enter email address:");
            email = Console.ReadLine();
            
        }

    }
}
