using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class Student
    {
        private int studentID;
        public int StudentID { get { return studentId; } set { studentId = value; } }

        Student(int studentID)
        {
            this.studentID = studentID;
        }
    }
}
