using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;
using WeltecOnlineShop.Myclass;


namespace WeltecOnlineShop
{
    public partial class LogIn : System.Web.UI.Page
    {
        General objGe = new General(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@USername",txtUsername.Text);
            nv.Add("@Password", txtPswd.Text);

            dt = objGe.GetDataTable("GET_LogIn", nv);

            if(dt != null  && dt.Rows.Count>0)
            {
                Session["Name"] = dt.Rows[0]["UserName"].ToString();
                Response.Redirect("DashBoard.aspx");

                lblmsg.Text = "Login Successfully";

            }
            else 
            {
                lblmsg.Text = "Invalid Username and Password";
                    
                    
            }
        }
    }
}