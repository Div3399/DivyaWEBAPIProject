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
    public partial class Category : System.Web.UI.Page
    {
        General objG = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindGV();
            }
        }

        private int CategoryId
        {
            get
            {
                if (ViewState["CategoryId"] == null)
                {
                    return 0;
                }
                else
                {
                    return (int)ViewState["CategoryId"];
                }
            }
            set
            {
                ViewState["CategoryId"] = value;
            }
        }

        private void bindGV()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@CategoryId", CategoryId.ToString());
            nvc.Add("@Name", txtSearchTerm.Text);

            dt = objG.GetDataTable("GET_Category", nvc);
            GVCateforyDisplay.DataSource = dt;
            GVCateforyDisplay.DataBind();
            clear();
        }

        private void clear()
        {
            txtCatName.Text = string.Empty;
            txtSearchTerm.Text = string.Empty;  
        }

        private void ReadOnly()
        {
            txtCatName.ReadOnly = true;
            btnSave.Enabled = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@CategoryId", CategoryId.ToString());
            nvc.Add("@CategoryName", txtCatName.Text);
            nvc.Add("@IsActive", "1");

            int IsSuccess = 0;
            IsSuccess = objG.GetDataExecuteScaler("SET_AddCategory", nvc);
            if (IsSuccess > 0)
            {
                LblMsg.Text = "Record Inserted/Updated Successfully";
                bindGV();
                clear();
            }
            else
            {
                LblMsg.Text = "Error In Insertation/Updation";
            }
        }

        protected void txtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            bindGV();
        }

        protected void GVCateforyDisplay_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditCategory")
            {
                CategoryId = Convert.ToInt32(e.CommandArgument);
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("@CategoryId", CategoryId.ToString());
                nvc.Add("@Name", txtSearchTerm.Text);
                DataTable dt = new DataTable();
                dt = objG.GetDataTable("GET_Category", nvc);

                if (dt != null && dt.Rows.Count > 0)
                {
                    txtCatName.Text = dt.Rows[0]["CategoryName"].ToString();
                }
            }
            else if (e.CommandName == "DeleteCategory")
            {
                CategoryId = Convert.ToInt32(e.CommandArgument);
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("@CategoryId", CategoryId.ToString());

                int IsSuccess = objG.GetDataExecuteScaler("SET_DeleteCategory", nvc);
                bindGV();
            }
            else if (e.CommandName == "ViewCategory")
            {
                CategoryId = Convert.ToInt32(e.CommandArgument);
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("@CategoryId", CategoryId.ToString());
                nvc.Add("@Name", txtSearchTerm.Text);
                DataTable dt = new DataTable();
                dt = objG.GetDataTable("GET_Category", nvc);

                if (dt != null && dt.Rows.Count > 0)
                {
                    ReadOnly();
                    txtCatName.Text = dt.Rows[0]["CategoryName"].ToString();
                }
            }
        }
        protected void lnkbtnClear_Click(object sender, EventArgs e)
        {
            txtSearchTerm.Text = string.Empty;
            bindGV();
        }

        protected void GVCateforyDisplay_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVCateforyDisplay.PageIndex = e.NewPageIndex;
            bindGV();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            ViewState["CategoryId"] = 0;
            bindGV();
        }
    }
}