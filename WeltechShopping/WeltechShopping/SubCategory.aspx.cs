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
    public partial class SubCategory : System.Web.UI.Page
    {
        General objG = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindCategory();
                bindGV();
            }
        }

        private int SubcategoryId
        {
            get
            {
                if (ViewState["SubcategoryId"] == null)
                {
                    return 0;
                }
                else
                {
                    return (int)ViewState["SubcategoryId"];
                }
            }
            set
            {
                ViewState["SubcategoryId"] = value;
            }
        }

        private void bindCategory()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@CategoryId", "0");
            nvc.Add("@Name", txtSearchTerm.Text);

            dt = objG.GetDataTable("GET_Category", nvc);
            ddlCategory.DataSource = dt;
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "CategoryId";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "--Select--");
        }

        private void bindGV()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@SubCatId", SubcategoryId.ToString());
            nvc.Add("@Name", txtSearchTerm.Text);
            dt = objG.GetDataTable("GET_SubCategory", nvc);
            if (dt.Rows.Count > 0 && dt != null)
            {
                GVDisplay.DataSource = dt;
                GVDisplay.DataBind();
            }
            else
            {
                LblMsg.Text = "There is Nothing to Display";
            }

        }

        private void clear()
        {
            txtSubCatName.Text = string.Empty;
            txtSearchTerm.Text = string.Empty;
            bindCategory();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@SubCatId", SubcategoryId.ToString());
            nvc.Add("@CategoryId", ddlCategory.SelectedValue);
            nvc.Add("@SubCatName", txtSubCatName.Text);
            nvc.Add("@IsActive", "1");

            int IsSuccess = 0;
            IsSuccess = objG.GetDataExecuteScaler("SET_AddSubCategory", nvc);
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            bindGV();
        }

        protected void txtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            bindGV();
        }

        protected void lnkbtnClear_Click(object sender, EventArgs e)
        {
            txtSearchTerm.Text = string.Empty;
            bindGV();
        }

        protected void GVDisplay_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditSubCategory")
            {
                SubcategoryId = Convert.ToInt32(e.CommandArgument);
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("@SubCatId", SubcategoryId.ToString());
                nvc.Add("@Name", txtSearchTerm.Text);
                DataTable dt = new DataTable();
                dt = objG.GetDataTable("GET_SubCategory", nvc);

                if (dt != null && dt.Rows.Count > 0)
                {
                    txtSubCatName.Text = dt.Rows[0]["SubCatName"].ToString();
                    bindCategory();
                    ddlCategory.SelectedValue = dt.Rows[0]["CategoryId"].ToString();
                }
            }
            else if (e.CommandName == "DeleteSubCategory")
            {
                SubcategoryId = Convert.ToInt32(e.CommandArgument);
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("@SubCatId", SubcategoryId.ToString());

                int IsSuccess = objG.GetDataExecuteScaler("SET_DeleteSubcategory", nvc);
                bindGV();
            }
        }

        protected void GVDisplay_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVDisplay.PageIndex = e.NewPageIndex;
            bindGV();
        }
    }
}