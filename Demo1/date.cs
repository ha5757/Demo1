using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    interface IValidate
    {
        bool ValidateAge();

        bool ValidateEmail();

        void Print();
    }
    class Employee : IValidate
    {
        int empno;
        String ename;
        String email;
        DateTime Dob;
        DateTime Doj;

        public Employee(int empno, string ename, string email, DateTime dob, DateTime doj)
        {
            this.empno = empno;
            this.ename = ename;
            this.email = email;
            Dob = dob;
            Doj = doj;
        }

        public void Print()
        {
            if (ValidateAge() && ValidateEmail())
                Console.WriteLine("Eno: " + empno + " EmpName: " + ename + " Email: " + email + " DOB: " + Dob + " DOJ: " + Doj);
            else if (!ValidateAge() && !ValidateEmail())
                Console.WriteLine("Under age and Invalid Email");
            else if (!ValidateAge())
                Console.WriteLine("Under age");
            else if (!ValidateEmail())
                Console.WriteLine("Not a valid email");
        }

        public bool ValidateAge()
        {
           // DateTime Dob = DateTime.ParseExact(Dob, "dd-MM-yyyy", CultureInfo.InvariantCulture);
           // DateTime Doj = DateTime.ParseExact(Doj, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int diff = (int)Doj.Subtract(Dob).TotalDays / 365;
            if (diff >= 21)
                return true;
            else
                return false;
        }

        public bool ValidateEmail()
        {
            if ((email.Substring(0, email.IndexOf("@")).Length >= 4) && (email.IndexOf("@") == email.LastIndexOf("@")) && (email.IndexOf(".") - email.IndexOf("@") >= 4))
                return true;
            else
                return false;
        }
    }
    class date
    {
        static void Main(string[] args)
        {

            IValidate iv = new Employee(1, "manichandna", "manu@gmail.com", DateTime.Parse("1998-07-14"),DateTime.Parse("2020-07-14"));
            iv.Print();
    
            Console.Read();
        }
    }
}
