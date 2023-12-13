using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Task04A
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number to divide 100: ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int result = 100;
                Console.WriteLine("100 / {0} = {1}", num, result);
            }
        }
    }
}
