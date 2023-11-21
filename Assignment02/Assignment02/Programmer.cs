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

        public Programmer() : base("", 0)
        {

        }

        public int Salary
        {
            get { return salary; }
        }

    }
}
