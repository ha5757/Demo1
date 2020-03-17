using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdemo.Assessment1
{
    class Themain
    {
        static void Main(string[] args)
        {
            User[] U = new User[5];
            U[0] = new User("bhaskarreddy", "teacher", 45);
            U[1] = new User("harishma", "engineer", 22);
            U[2] = new User("Sai", "business", 65);
            U[3] = new User("mahesh", "Landlord", 35);
            U[4] = new User("venkat reddy", "Retired", 70);
            for (int i = 0; i < U.Length; i++)
            {
                if (U[i].Age > 60)
                {
                    Console.WriteLine(U[i]);
                    Console.WriteLine("---------------------------------");
                }
            }
            Console.ReadLine();
        }
    }
}
