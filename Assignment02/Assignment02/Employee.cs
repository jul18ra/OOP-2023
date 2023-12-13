using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment02
{
    internal class Employee : Person
    {
        private string companyName;
        private int employeeNumber;

        public Employee(string name, string address, string companyName, int employeeNumber) : base(name, address)
        {
            this.companyName = companyName;
            this.employeeNumber = employeeNumber;  
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public int EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }
    }
}
