using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Person
    {
        string name;
        string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
    }
}
