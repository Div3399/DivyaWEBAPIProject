using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeltecOnlineShop.Myclass;

namespace WeltecOnlineShop
{
    public partial class SubCategoryMaster : System.Web.UI.Page
    {
        General objGe = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindcategory();
                bindgv();
            }

        }

        private long SubcategoryId
        {
            get
            {
                if (ViewState["SubcategoryId"] != null)
                {
                    return (long)ViewState["SubcategoryId"];
                }
                return 0;

            }
            set
            {
                ViewState["SubcategoryId"]=value;
            }
        }

        private void bindcategory()
        {
            DataTable dt = new DataTable(); 
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@CategoryId","0");
            nv.Add("@CategoryName","");
           

            dt = objGe.GetDataTable("Get_Cat", nv);

            ddlCategoryName.DataSource = dt;
            ddlCategoryName.DataValueField = "CategoryId";
            ddlCategoryName.DataTextField = "CategoryName";
            ddlCategoryName.DataBind();
            ddlCategoryName.Items.Insert(0, "---Select Category---");


        }

        private void bindgv()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@SubcategoryId", SubcategoryId.ToString());
            nv.Add("@SubcategroyName", txtSearch.Text );
            nv.Add("@Mode", "1");

            dt = objGe.GetDataTable("Get_Subcategory", nv);

            GridviewSubcategory.DataSource = dt;
            GridviewSubcategory.DataBind();
            clear();

        }

        private void clear()
        {
            txtSubCatName.Text= string.Empty;
            txtSearch.Text= string.Empty;
            bindcategory();
        }

        protected void lnkbtnSave_Click(object sender, EventArgs e)
        {
            int Isresult = 0;

            NameValueCollection nv= new NameValueCollection();

            nv.Add("@SubcategoryId", SubcategoryId.ToString());
            nv.Add("@CategoryId", ddlCategoryName.SelectedValue);
            nv.Add("@SubcategoryName", txtSubCatName.Text);

            Isresult = objGe.GetDataExecuteScaler("Set_AddSubcategory", nv);

            if (Isresult > 0 )
            {
                lblmsg.Text = "Saved!..";
                bindgv();
                clear();
            }
            else
            {
                lblmsg.Text = "Unsuccessfully Record insertion ...";
            }

        }

        protected void lnkbtnCancel_Click(object sender, EventArgs e)
        {
            clear();
            ViewState["Subcategoryid"] = 0;
            bindgv();

        }

        protected void GridviewSubcategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridviewSubcategory.PageIndex = e.NewPageIndex;
            bindgv();
        }

        protected void GridviewSubcategory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SubcatEdit")
            {
                SubcategoryId = Convert.ToInt32(e.CommandArgument);
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection(); 
                nv.Add("@SubcategoryId",SubcategoryId.ToString());
                nv.Add("@SubcategroyName", txtSubCatName.Text);
                nv.Add("@Mode", "2");

                dt = objGe.GetDataTable("Get_Subcategory", nv);

                if (dt !=null && dt.Rows.Count>0)
                {
                    txtSubCatName.Text = dt.Rows[0]["SubcategroyName"].ToString();
                    ddlCategoryName.SelectedValue = dt.Rows[0]["CategoryId"].ToString() ;
                }


            }


            if (e.CommandName == "SubcatDelete")
            {
                SubcategoryId = Convert.ToInt32(e.CommandArgument) ;
                int Isreult = 0;

                NameValueCollection nv = new NameValueCollection();
                nv.Add("@SubcategoryId", SubcategoryId.ToString());

                Isreult = objGe.GetDataExecuteScaler("Set_DeleteSubcategory", nv);
                bindgv();

            }

        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            bindgv();
        }

        protected void lnkbtnSearch_Click(object sender, EventArgs e)
        {
            bindgv();
        }
    }
}