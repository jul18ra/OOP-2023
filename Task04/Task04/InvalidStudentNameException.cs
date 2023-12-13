using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() 
        {
            Console.WriteLine("Invalid student ID");
        }
    }
}
