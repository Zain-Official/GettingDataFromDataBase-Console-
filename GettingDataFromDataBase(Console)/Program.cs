using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GettingDataFromDataBase_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***********************************************");
            SqlConnection conn = new SqlConnection(@"Integrated security= true; data source=DESKTOP-N43NUMQ\ZAIN_SINDHI; initial catalog=Practice");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from employe", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "employe");
            foreach (DataRow dr in ds.Tables["employe"].Rows)
            {
                Console.WriteLine("Employe Id : " + dr["emp_ID"]);
                Console.WriteLine("Employe Name : " + dr["emp_Name"]);
                Console.WriteLine("Employe Age : " + dr["emp_Age"]);
                Console.WriteLine("Employe Country : " + dr["emp_Nationality"]);
                Console.WriteLine("Employe Gender : " + dr["emp_Gender"]);
                Console.WriteLine("Employe Salary : " + dr["emp_Salary"]);

                Console.WriteLine("***********************************************");


            }
            Console.ReadKey();
        }
    }
}
