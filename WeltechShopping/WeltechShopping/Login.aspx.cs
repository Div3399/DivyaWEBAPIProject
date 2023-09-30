using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WeltechShopping.MyClass;

namespace arethmeticOperation
{
    public partial class Login : System.Web.UI.Page
    {
        General objG = new General();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLoginSession_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@UserName", txtUName.Text);
            nv.Add("@Password", txtPWD.Text);

            dt = objG.GetDataTable("SP_Login", nv);
            if (dt.Rows.Count > 0 && dt != null)
            {
                Session["Id"] = dt.Rows[0]["LoginId"].ToString();
                Session["UserName"] = dt.Rows[0]["UserName"].ToString();
                ViewState["Id"] = dt.Rows[0]["LoginId"].ToString();
                ViewState["UserName"] = dt.Rows[0]["UserName"].ToString();

                lblMsg.Text = " ViewState Id = " + ViewState["Id"] + "   " + "ViewState UserName = " + ViewState["UserName"];
                Response.Redirect("AdminDashboard.aspx?UserName=" + txtUName.Text + "&Id=" + dt.Rows[0]["LoginId"].ToString());
            }
            else
            {
                lblMsg.Text = "Invalid UserName or Password";
            }

        }
    }
}