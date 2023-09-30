using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WeltecDemo.MyClass;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;


namespace WeltecDemo
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SignUp objSu = new SignUp();

        General objGE = new General();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();

            nv.Add("@Username", txtusername.Text);
            nv.Add("@Password", txtPswd.Text);
           

            dt = objGE.GetDataTable("LoginPage", nv);


            if (dt!= null && dt.Rows.Count>0)
            {
                Session["EmpId"] = dt.Rows[0]["ID"].ToString();
                Session["Name"] = dt.Rows[0]["first_name"].ToString();
                Response.Redirect("NewHome.aspx");

                lblmsg.Text = "LogIn Successfully...!";
                
            
            }
            else
            {

                lblmsg.Text = "Invalid Username password";
               
            }

        }
    }
}