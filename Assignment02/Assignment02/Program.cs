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
        private string name = "";
        private string address = "";
        private string companyName = "";
        private string employeeCategory = "";
        private int employeeNumber = 0;
        private bool employeeNumberIsValid;
        private int salary = 0;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreateEmployee();
        }

        private void AskForInfo()
        {
            Console.WriteLine("Enter employee name:");
            name = Console.ReadLine() ?? "";
            Console.WriteLine("\n");

            Console.WriteLine("Enter employee address:");
            address = Console.ReadLine() ?? "";
            Console.WriteLine("\n");

            Console.WriteLine("Enter company name:");
            companyName = Console.ReadLine() ?? "";
            Console.WriteLine("\n");

            while (employeeCategory != "programmer" & employeeCategory != "tester" & employeeCategory != "marketer")
            {
                Console.WriteLine("Enter employee category (programmer, tester, marketer):");
                employeeCategory = Console.ReadLine() ?? "programmer";

                if(employeeCategory != "programmer" & employeeCategory != "tester" & employeeCategory != "marketer")
                {
                    Console.WriteLine("Invalid category");
                }
                Console.WriteLine("\n");

            }

            while (!employeeNumberIsValid)
            {
                Console.WriteLine("Enter employee number:");
                try
                {
                    employeeNumber = Int32.Parse(Console.ReadLine() ?? "0");
                    employeeNumberIsValid = true;   
                }
                catch
                {
                    Console.WriteLine("Invalid employee number");
                    Console.WriteLine("\n");

                }

            }


        }

        private void PickEmployeeCategory()
        {
            switch (employeeCategory)
            {
                case "programmer":
                    Programmer programmer = new Programmer(name, address, companyName, employeeNumber);
                    salary = programmer.Salary;
                    break;

                case "tester":
                    Tester tester = new Tester(name, address, companyName, employeeNumber);
                    salary = tester.Salary;
                    break;

                case "marketer":
                    Marketer marketer = new Marketer(name, address, companyName, employeeNumber);
                    salary = marketer.Salary;
                    break;
            }

        }

        private void DisplayInfo()
        {
            Console.WriteLine($"Employee name: {name}");
            Console.WriteLine($"Employee address: {address}");
            Console.WriteLine($"Company name: {companyName}");
            Console.WriteLine($"Employee number: {employeeNumber}");
            Console.WriteLine($"Employee salary: {salary}");
        }

        private void CreateEmployee()
        {
            AskForInfo();
            PickEmployeeCategory();
            DisplayInfo();
        }

    }
}
