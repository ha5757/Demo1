using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.collectionex
{
    class genericex
    {
        static void Main(string[] args)
        {
            //dynamic array
            List<string> L = new List<string>();
            L.Add("one");
            L.Add("two");
            for (int i = 0; i <L.Count; i++)
            {
                Console.WriteLine(L[i]);
            }
            List<int> L1 = new List<int>();
            L1.Add(10);
            L1.Add(20);
            L1.Add(90);
            L1.Add(50);
            L1.Add(40);
            L1.Sort();
            for (int i = 0; i < L1.Count; i++)
            {
                Console.WriteLine(L1[i]);
            }
            HashSet<int> H = new HashSet<int>();
            H.Add(10);
            H.Add(20);
            H.Add(90);
            H.Add(50);
            foreach(int i1 in H)
            {
                Console.WriteLine(i1);
            }
            Dictionary<long, string> D = new Dictionary<long, string>();
            D.Add(506370, "wgl");
            D.Add(300000, "hyd");
            D.Add(506782, "delhi");
            ICollection<long> I = D.Keys;
            foreach (int l in I)
            {
                Console.WriteLine(l +" " + D[l]);
            }

            SortedDictionary<long, string> D1 = new SortedDictionary<long, string>();
            D1.Add(506370, "wgl");
            D1.Add(300000, "hyd");
            D1.Add(506782, "delhi");
            ICollection<long> I1 = D1.Keys;
            foreach (int l in I1)
            {
                Console.WriteLine(l + " " + D1[l]);
            }
            Console.Read();
           
        }
    }
}
