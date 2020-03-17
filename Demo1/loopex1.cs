using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class loop
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                for (int j= 0; j < 5; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }
            Console.Read();
        }
    }
}
