using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopesDemo.Assignment1
{
    class Userdefined : Exception
    {
        public Userdefined(string message) : base(message)
        {
        }
    }
    class Age
    {
        DateTime DOB;
        public Age(DateTime dOB)
        {
            DOB = dOB;
        }
        public void age()
        {
            int age;
            DateTime present = DateTime.Now;
            try
            {
                age = (int)(present.Subtract(DOB).TotalDays / 365);
                if (age > 21 && age < 58)
                    Console.WriteLine("Age : " + age);
                else if (age < 21)
                    throw new Userdefined("Age must not be less than 21");
                else if (age > 58)
                    throw new Userdefined("Age must not be greater than 58");
            }
            catch (Userdefined E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
    class MainCls1
    {
        static void Main(string[] args)
        {
            string Date;
            Console.Write("Enter DOB:");
            Date = Console.ReadLine();
            DateTime D = DateTime.ParseExact(Date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Age A = new Age(D);
            A.age();
            Console.Read();
        }
    }
}