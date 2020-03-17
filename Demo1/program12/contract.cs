using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.program12
{
    class contract:Emp
    {
        double Renum, Finalpay;
        public contract(int empno, string empname, string gender, int Basic) : base(int empno, string empname, string gender)
        {
            this.Basic = Basic;
          
        }
        private void Calculate()
        {
            Finalpay= Renum - Renum * 0.05;

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(Renum);
            Calculate();
            Console.WriteLine(Finalpay);
        }
    }
}
