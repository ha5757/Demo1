using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.exceptions
{
    class CustomException : Exception
    {
        public CustomException(string S): base(S)
        {

        }
    }
    class Class3
    {
        static void Main(string[] args)
        {
            try
            {
                int age = int.Parse(Console.ReadLine());
                int basic = int.Parse(Console.ReadLine());
                if (age < 21 || age > 58)
                {
                    throw new CustomException("age between 21-58 only");
                }
                else
                {
                    Console.WriteLine("Age is" + age);
                }
                if (basic < 20000)
                    throw new CustomException("basic cannot be less than 20000");
            }
            catch(FormatException E)
            {
                Console.WriteLine("ENTER ONLY NUMBERS" +E.Message);
            }
            catch (CustomException E)
            {
                Console.WriteLine( E.Message);
            }
            Console.ReadLine();
        }
    }
}
