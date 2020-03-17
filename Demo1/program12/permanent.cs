using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.program12
{
    class permanent:Emp
    {
        double netpay, Basic;
        public permanent(int empno,string empname,string gender,int Basic):base(int empno,string empname,string gender)
        {
            this.Basic = Basic;
            this.netpay = netpay;
            public void Calculate()
            {
                netpay= Basic + Basic * 0.1;

            }
            public override void Print()
            {
            base.Print();
            Console.WriteLine(Basic);
            Calculate();
            Console.WriteLine(netpay);

            }
        }
    }
}
