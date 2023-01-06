using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Managment_Project
{
    internal class Function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private String Constr;
        public Function()
        {
            Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\bavly\4th_year\first_term\first term\window\Employee_Managment_Project\emplyeeDatabasse.mdf"";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = con;

        }
        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);
            sda.Fill(dt);
            return dt;

        }
        public int SetData(String Query)
        {
            int cnt = 0;
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}
