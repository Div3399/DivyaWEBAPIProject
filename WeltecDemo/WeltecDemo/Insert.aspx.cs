using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using WeltecDemo.MyClass;
using System.Security.Policy;

namespace WeltecDemo
{
    public partial class Insert : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-D0537QQO\\SQLEXPRESS;Initial Catalog=Weltec;Integrated Security=True");
           
            string str = "";
            str = "delete from employees where Last_Name = '"+txtLname.Text+"' ";

            con.Open();

            SqlCommand Cmd = new SqlCommand(str, con);
            Cmd.ExecuteNonQuery();

            lblmsg.Text = "Deleted";
            txtLname.Text = "";


        }
    }
}