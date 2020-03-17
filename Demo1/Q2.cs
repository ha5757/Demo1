using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OopesDemo.adodotnetconsole.Test
{

    class Adodotnet
    {

        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            Console.Write("Enter Product ID : ");
            int pid = int.Parse(Console.ReadLine());
           
            try
            {
                con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=exam;Data Source=DESKTOP-I8O23UC");
                con.Open();
                cmd = new SqlCommand("select product_id,product_name,description,standard_cost,list_price from productinfo where product_id=@Pid", con);
                cmd.Parameters.AddWithValue("@Pid",pid);
                SqlDataReader R = cmd.ExecuteReader();
                R.Read();
                Console.WriteLine("PRODUCT_ID : " + R[0]);
                Console.WriteLine("PRODUCT_NAME : " + R[1]);
                Console.WriteLine("DESCRIPTION : " + R[2]);
                Console.WriteLine("STANDARD_COST : " + R[3]);
                Console.WriteLine("LIST_PRICE : " + R[4]);
            }
            catch (InvalidOperationException E)
            {
                Console.WriteLine("Enter Valid Product_id");
            }
            finally
            {
                con.Close();
            }
          
            Console.Read();
        }
    }
}