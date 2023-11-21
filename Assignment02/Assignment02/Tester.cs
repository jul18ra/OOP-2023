using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Tester : Employee
    {
        private int salary = 3400;

        public Tester() : base("", 0)
        {

        }

        public int Salary
        {
            get { return salary; }
        }
    }
}
