using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task04
{
    public class Task04B
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
            catch (InvalidStudentIDException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        private static void ValidateStudent(Student student)
        {
            string pattern = @"[0-9]";
            Regex rgx = new Regex(pattern);

            if (rgx.IsMatch(student.StudentID))
            {
                Console.WriteLine("Student ID is valid");
            }
            else
            {
                throw new InvalidStudentIDException();
            }

        }
    }
}




