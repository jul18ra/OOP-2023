using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Console.WriteLine("Enter full name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter email address:");
            email = Console.ReadLine();

        }
    }
}
