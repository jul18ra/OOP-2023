using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Program
    {
        public static void Main()
        {
            bool inputIsValid = false;

            while (!inputIsValid)
            {
                Console.WriteLine("Please enter a number to divide 100: ");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    int result = 100 / num;
                    Console.WriteLine("100 / {0} = {1}", num, result);
                    inputIsValid = true;    
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by zero");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be of type int");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Invalid operation");
                }
                catch
                {
                    Console.WriteLine("An error has occurred");
                }
            }
        }
    }
}
