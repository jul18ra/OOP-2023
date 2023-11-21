using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Marketer : Employee
    {
        private int salary = 3600;

        public Marketer() : base("", 0)
        {

        }

        public int Salary
        {
            get { return salary; }
        }
    }
}
