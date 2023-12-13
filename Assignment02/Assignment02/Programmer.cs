using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Programmer : Employee
    {
        private int salary = 3900;

        public Programmer(string name, string address, string companyName, int employeeNumber) : base(name, address, companyName, employeeNumber)
        {
        }

        public int Salary
        {
            get { return salary; }
        }

    }
}
