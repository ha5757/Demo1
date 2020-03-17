using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Class1
    {
        static void Main(string[] args)
        {

            string[] S = { "abc@gmail.com", "sample@gmail.com" };
            int index = 0;
            for (int i = 0; i < S.Length; i++)
            {
                index = S[i].IndexOf('@');
                Console.Write("\"" + S[i].Substring(0, index) + "\"");
            }
            Console.Read();
        }
    }
}
