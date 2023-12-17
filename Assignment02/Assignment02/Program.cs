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
            Program program = new Program();
            program.CreateEmployee();
        }

        private void CreateEmployee()
        {
            string name = AskForInfo("name");
            string address = AskForInfo("address");
            string companyName = AskForInfo("company name");
            int employeeNumber = AskForEmployeeNumber();
            int salary = CalculateEmployeeSalary(name, address, companyName, employeeNumber);

            Console.WriteLine($"Employee name: {name}");
            Console.WriteLine($"Employee address: {address}");
            Console.WriteLine($"Company name: {companyName}");
            Console.WriteLine($"Employee number: {employeeNumber}");
            Console.WriteLine($"Employee salary: {salary}");
        }

        private string AskForInfo(string info)
        {
            Console.WriteLine($"Enter {info}:");
            string infoInput = Console.ReadLine() ?? "";
            Console.WriteLine("\n");
            return infoInput;
        }

        private string AskForEmployeeCategory()
        {
            string employeeCategory = "";
            
            while (employeeCategory != "programmer" & employeeCategory != "tester" & employeeCategory != "marketer")
            {
                Console.WriteLine("Enter employee category (programmer, tester, marketer):");
                employeeCategory = Console.ReadLine() ?? "programmer";

                if (employeeCategory != "programmer" & employeeCategory != "tester" & employeeCategory != "marketer")
                {
                    Console.WriteLine("Invalid category");
                }
                Console.WriteLine("\n");
            }

            return employeeCategory;
        }

        private int AskForEmployeeNumber()
        {
            bool employeeNumberIsValid = false;
            int employeeNumber = 0; 

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
            return employeeNumber;

        }

        private int CalculateEmployeeSalary(string name, string address, string companyName, int employeeNumber)
        {
            string employeeCategory = AskForEmployeeCategory();
            int salary = 0;

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

            return salary;

        }
    }
}
