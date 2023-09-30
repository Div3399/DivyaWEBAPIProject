using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeltechShopping.MyClass;

namespace WeltechShopping
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        General objG = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindLables();
            }
        }

        private void bindLables()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            dt = objG.GetDataTable("SP_GETCount", nvc);

            if (dt != null && dt.Rows.Count > 0)
            {
                lblTotCategory.Text = dt.Rows[0]["TotCategory"].ToString();
                lblTotSubCategory.Text = dt.Rows[0]["TotSubCat"].ToString();
                lblTotProducts.Text = dt.Rows[0]["TotProduct"].ToString();
            }
        }
    }
}