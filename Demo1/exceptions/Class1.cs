using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.exceptions
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
                int n = int.Parse(Console.ReadLine());
                arr[n] = 100;
                Console.WriteLine(arr[n]);
            }

            catch(DivideByZeroException E)
            {
                Console.WriteLine("2ND INPUT SHOULD NOT BE ZERO");
            }
            catch (FormatException E)
            {
                Console.WriteLine("enter integer value");
            }
            catch (IndexOutOfRangeException E)
            {
                Console.WriteLine("enter only between 0-4");
            }

            Console.ReadLine();
        }
    }
}
