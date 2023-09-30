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
    public partial class CategoryMaster : System.Web.UI.Page
    {
        General objGa = new General();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindgridview();

            }

        }

        private long CatId
        {
            get
            {
                if (ViewState["CatId"] != null)
                {
                    return (long)ViewState["CatId"];
                }
                return 0;
            }
            set
            {
                ViewState["CatId"] = value;
            }
        }


        private void bindgridview()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            
            nv.Add("@CategoryId", CatId.ToString());
            nv.Add("@CategoryName" , txtSearch.Text);
            nv.Add("@Mode", "1");

            dt = objGa.GetDataTable("Get_category", nv);

            GridCat.DataSource = dt;
            GridCat.DataBind();
            clear();
        }

        private void clear()
        {
            txtcat.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        private void ReadOnly()
        {
            txtcat.ReadOnly = true;
            lnkbtnSave.Enabled = false;
        }

        protected void lnkbtnSave_Click(object sender, EventArgs e)
        {
            int Isresult = 0;

            NameValueCollection nv = new NameValueCollection();
            nv.Add("@CategoryId" , CatId.ToString());
            nv.Add("@CategoryName" , txtcat.Text);
            

            Isresult = objGa.GetDataExecuteScaler("Set_AddCategory", nv);

            if (Isresult > 0)
            {
                lblmsg.Text = "Saved Successfully...!";
                bindgridview();
                clear();
            }
            else
            {
                lblmsg.Text = "UnSaved ....!";
            }
        }

        protected void lnkbtnCancel_Click(object sender, EventArgs e)
        {
            clear();
            ViewState["CategoryId"] = 0;
            bindgridview() ;
        }

        protected void GridCat_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCat.PageIndex = e.NewPageIndex;
            bindgridview();
        }

        protected void GridCat_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "CatDlt")
            {
                CatId = Convert.ToInt32(e.CommandArgument);
                int Isresult = 0;

                NameValueCollection nv = new NameValueCollection();
                nv.Add("@CategoryId", CatId.ToString());

                Isresult = objGa.GetDataExecuteScaler("Set_DeleteCategory", nv);

                 
                
            }
            if(e.CommandName == "CatEdit")
            {
                CatId = Convert.ToInt32(e.CommandArgument);    
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add ("@CategoryId", CatId.ToString ()); 
                nv.Add ("@CategoryName", txtcat.Text);
                nv.Add("@Mode", "2");

                dt = objGa.GetDataTable("Get_category", nv);

                if(dt != null && dt.Rows.Count>0)
                {
                    txtcat.Text = dt.Rows[0]["CategoryName"].ToString();
                }

            }
            if(e.CommandName == "CatView")
            {
                CatId = Convert.ToInt32 (e.CommandArgument);
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@CategoryId", CatId.ToString());
                nv.Add("@CategoryName", txtSearch.Text);
                nv.Add("@Mode", "2");
               

                dt = objGa.GetDataTable ("Get_category", nv);

                if(dt !=null && dt.Rows.Count>0)
                {
                    ReadOnly();
                    txtcat.Text = dt.Rows[0]["CategoryName"].ToString ();
                   
                }

            }
        }

        protected void lnkbtnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty; 
            bindgridview();
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            bindgridview();
        }

    }

}