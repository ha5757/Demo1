using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo.EXAM
{
    class user
    {


        public user(string name, string occ, int age)
        {
            this.Name = name;
            this.Occ = occ;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Occ { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "name: " + Name + "\n" + "occ:" + Occ + "\n" + "age:" + Age + "\n";
        }


        static void Main(string[] args)
        {
            user[] u = new user[5];
            u[0] = new user("bhaskarreddy", "teacher", 76);
            u[1] = new user("saritha", "typist", 23);
            u[2] = new user("venkat reddy", "retiredteacher", 66);
            u[3] = new user("megana", "doctor", 45);
            u[4] = new user("anasuya", "clerk", 71);

            Console.WriteLine("enter 1:senior citizen or 2:citizen");
            int a = int.Parse(Console.ReadLine());






            if (a == 1)
            {
                Console.WriteLine("senior citizens");


                for (int i = 0; i < 5; i++)
                {
                    if (u[i].Age > 60)
                    {
                        Console.WriteLine(u[i]);
                    }

                }
            }
            if (a == 2)
                Console.WriteLine("citizens");
            {


                for (int i = 0; i < 5; i++)
                {
                    if (u[i].Age < 60)
                    {
                        Console.WriteLine(u[i]);
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
