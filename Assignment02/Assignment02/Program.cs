using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name;
            string? address;
            string? companyName;
            string? employeeCategory;
            string? employeeNumber;


            Console.WriteLine("Enter employee name:");
            name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Enter employee address:");
            address = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Enter company name:");
            companyName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Enter employee category (programmer, tester, marketer):");
            employeeCategory = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Enter employee number:");
            employeeNumber = Console.ReadLine();
            Console.WriteLine("\n");

            switch (employeeCategory)
            {
                case "programmer":
                    Programmer programmer = new Programmer();
                    break;

                case "tester":
                    Tester tester = new Tester();
                    break;

                case "marketer":
                    Marketer marketer = new Marketer();
                    break;
            }
        }

    }
}
