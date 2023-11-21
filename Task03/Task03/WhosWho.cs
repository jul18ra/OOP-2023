using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class WhosWho
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Greet();

            Student mary = new Student();
            mary.SetAge(12);
            mary.Greet();
            mary.ShowAge();
            mary.Study();

            Teacher james = new Teacher();
            james.SetAge(36);
            james.Greet();
            james.Explain();
        }
    }
}
