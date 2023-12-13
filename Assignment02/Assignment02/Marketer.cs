using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment02
{
    internal class Marketer : Employee
    {
        private int salary = 3600;
        public Marketer(string name, string address, string companyName, int employeeNumber) : base(name, address, companyName, employeeNumber)
        {
        }

        public int Salary
        {
            get { return salary; }
        }
    }
}
