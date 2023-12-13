using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Task04B
    {
        class Program
        {
            static void Main(string[] args)
            {
                Student newStudent = null;
                try
                {
                    newStudent = new Student();
                    newStudent.StudentID = "James007";
                    ValidateStudent(newStudent);
                }
                catch (InvalidStudentNameExceptionex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }

        }
    }
}
