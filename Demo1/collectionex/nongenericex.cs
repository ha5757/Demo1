using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Demo1.collectionex
{
    class nongenericex
    {
        static void Main(string[] args)
        {
            ArrayList A = new ArrayList();
            A.Add(10);
            A.Add(10.5);
            A.Add("HELLO");
            A.Add("true");
            A.Add('A');
            for (int i = 0; i < A.Count; i++)
            {
                Console.WriteLine(A[i]);
            }
            Hashtable H = new Hashtable();
            H.Add("AP","AMARAVTHI");
            H.Add("telangana", "hyderabad");
            //I WILL HAVE KEYS
            ICollection I = H.Keys;
            foreach(string s in I)
            {
                Console.WriteLine(s + " " +H[s]);
            }

            SortedList S = new SortedList();
            S.Add("AP", "AMARAVTHI");
            S.Add("telangana", "hyderabad");
            //I WILL HAVE KEYS
            ICollection I1 = S.Keys;
            foreach (string x in I1)
            {
                Console.WriteLine(x + " " +S[x]);
            }
            Stack st = new Stack();
            st.Push(10);
            st.Push(10.5);
            st.Push("hello");
            Console.WriteLine("before pop");
            Console.WriteLine(st.Pop());
            foreach (object o in st)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("after pop");
            Console.WriteLine(st.Pop());
            foreach (object o in st)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
        }
    }
}
