using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace WeltecDemo.MyClass
{
    public class ClassInsert
    {

        public int MyInsertQuery (string str)
        {
            int Isreuslt = 0;
           SqlConnection con = new SqlConnection("Data Source=LAPTOP-D0537QQO\\SQLEXPRESS;Initial Catalog=Weltec;Integrated Security=True");

            con .Open();

            SqlCommand Cmd = new SqlCommand(str, con);

            Isreuslt = Cmd.ExecuteNonQuery();

            return Isreuslt;

        }
    }
}