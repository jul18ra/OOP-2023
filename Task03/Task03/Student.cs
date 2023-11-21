using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm a studying student");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old.");
        }
    }
}
