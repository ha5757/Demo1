using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double i, j;
            //Accept the data in console app
            //implicit conversion or boxing
            i = int.Parse(Console.ReadLine());
            int k, l;
            //EXPLICIT CONVERSION OR UNBOXING
            k =(int)double.Parse(Console.ReadLine());
            long m, n;
            m = (long)double.Parse(Console.ReadLine());
            l= (int)long.Parse(Console.ReadLine());
            Console.WriteLine(i);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.Read();
        }
    }
}
