using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdemo.Assessment1
{
    class User
    {
        public User(string name, string occupation, int age)
        {
            Name = name;
            Occupation = occupation;
            Age = age;
        }

        public string Name { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\nOccupation: " + Occupation + "\nAge: " + Age;
        }
    }
}