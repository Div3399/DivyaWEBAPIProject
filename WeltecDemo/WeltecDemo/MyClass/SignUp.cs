using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WeltecDemo.MyClass
{
    public class SignUp
    {

        public int MyLogInPage(string str)
        {
            int Isresult = 0;

            SqlConnection con= new SqlConnection("Data Source=LAPTOP-D0537QQO\\SQLEXPRESS;Initial Catalog=Weltec;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand(str,con);

                
             Isresult= Convert.ToInt32(cmd.ExecuteScalar());
            
            
            return Isresult;
        }
    }
}