using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;


namespace WeltecDemo.MyClass
{
    public class ClassPrac
    {
        public int MyExecuteNonQuery(string str) 
        {
            int Isresult = 0;
            SqlConnection con= new SqlConnection("Data Source=LAPTOP-D0537QQO\\SQLEXPRESS;Initial Catalog=Weltec;Integrated Security=True");


            con.Open();

            SqlCommand cmd = new SqlCommand(str,con);


            Isresult = cmd.ExecuteNonQuery();

            return Isresult;

        }
        public int MyExecuteScalar(string str)
        {
            int Isresult = 0;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-D0537QQO\\SQLEXPRESS;Initial Catalog=Weltec;Integrated Security=True");


            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);


            Isresult = Convert.ToInt32(cmd.ExecuteScalar());

            return Isresult;

        }
        
        public SqlDataReader MyExecuteReader(string str) 
        {
            int IsResult = 0;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-D0537QQO\\SQLEXPRESS;Initial Catalog=Weltec;Integrated Security=True");
            
            SqlDataReader dr;
            con.Open();

            SqlCommand cmd = new SqlCommand(str,con);

            dr= cmd.ExecuteReader();

            return dr;


        }

    }
}