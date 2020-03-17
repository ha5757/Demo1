using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.program12
{
    class maincls
    {
        static void Main(string[] args)
        {
            Emp E = null;
            E.new permanent(1, "ram", "male", 5000);
            // E = new contract(2, "sam", "female", 10000);
            E.Print();
            Console.Read();
        }
    }
}
