using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.exceptions
{
    class Class2
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c;
                if (b != 0)
                    c = a / b;
                else
                    throw new DivideByZeroException("2nd no is not zero");
                Console.WriteLine(c);
            }
            catch (DivideByZeroException E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadLine();
        }
    }
}
