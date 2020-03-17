using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo.Question4
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Sales s = new Sales();
            Item i = null;
            Console.WriteLine("Press y to add");
            string str;
            while (true)
            {
                str = Console.ReadLine();
                Console.WriteLine("Enter Item id , Name, Location");
                if (str == "y")
                {
                    int id = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string loc = Console.ReadLine();
                    i = new Item(id, name, loc);
                    s.AddItem(i);
                    Console.WriteLine("Press y to add");
                }
                else
                {
                    break;
                }

            }
            try
            {
                Console.WriteLine("Enter item number to delete");
                Item i1 = s.FindandReturnItem(int.Parse(Console.ReadLine()));
                Console.WriteLine("Deleted Item :" + i1.ItemName1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Read();

        }
    }
}