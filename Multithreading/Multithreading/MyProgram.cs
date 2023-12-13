using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int input = Int32.Parse(Console.ReadLine());

            Thread thr1 = new Thread(userTimesTable);
            Thread thr2 = new Thread(userFactorial);

            thr1.Start(input);
            thr2.Start(input);
        }

        static void userTimesTable(object x)
        {
            int userInput = Convert.ToInt32(x);
            for (int n = 1; n <= 10; n++) 
            { 
                Console.WriteLine($"{userInput} x {n} = {userInput * n}");
            }
        }

        static void userFactorial(object x)
        {
            int userInput = Convert.ToInt32(x);

            int n = 1;
            int answer = 1;

            while (n <= userInput)
            {
                int a = answer;
                answer = answer * n;
                Console.WriteLine($"{a} x {n} = {answer}");

                n++;
            }
        }

    }
}
