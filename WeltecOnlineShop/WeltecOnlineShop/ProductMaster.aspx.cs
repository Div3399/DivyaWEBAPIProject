using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeltecOnlineShop.Myclass;

namespace WeltecOnlineShop
{
    public partial class ProductMaster : System.Web.UI.Page
    {
        General ObjGn = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            {
                Bindcategory();
                BindSubcategory();
                Bindbrand();
                bindSize();
                BindOffer();
                Bindcolor();
            }
        }

        private long Product
        {
            get
            {
                if (ViewState["Product"] != null)
                {
                    return (long)ViewState["Prodcut"];

                }
                return 0;

            }
            set 
            {
              ViewState["Product"] = value; 
            }
        }
        private void Bindcategory()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@CategoryId", "0");
            nv.Add("@CategoryName", "");


            dt = ObjGn.GetDataTable("Get_Cat",nv);

            ddlCategory.DataSource = dt;
            ddlCategory.DataValueField = "CategoryId";
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "---Select Category---");

        }

        private void BindSubcategory()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@SubcategoryId", "0");
            nv.Add("@SubcategoryName", "");

            dt = ObjGn.GetDataTable("Get_Subcat", nv);

            ddlSubcategory.DataSource = dt;
            ddlSubcategory.DataValueField = "SubcategoryId";
            ddlSubcategory.DataTextField = "SubcategoryName";
            ddlSubcategory.DataBind();
            ddlSubcategory.Items.Insert(0, "----Select Subcategory---");

        }

        private void Bindbrand()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@BRandId", "0");
            nv.Add("@BrandName", "");

            dt = ObjGn.GetDataTable("Get_Brand", nv);

            ddlBrand.DataSource = dt;
            ddlBrand.DataValueField = "BrandId";
            ddlBrand.DataTextField = "BrandName";
            ddlBrand.DataBind();
            ddlBrand.Items.Insert(0, "---Select Brand---");

        }

        private void bindSize()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv= new NameValueCollection();
            nv.Add("@SizeId", "0");
            nv.Add("@SizeName", "");

            dt = ObjGn.GetDataTable("Get_Size", nv);

            ddlsize.DataSource = dt;
            ddlsize.DataValueField = "SizeId";
            ddlsize.DataTextField = "SizeName";
            ddlsize .DataBind();
            ddlsize.Items.Insert(0, "---Select Size---");

        }

        private void BindOffer()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@OfferId", "0");
            nv.Add("@OfferName", "");

            dt = ObjGn.GetDataTable("Get_Offer", nv);

            ddlOffer.DataSource = dt;
            ddlOffer.DataValueField = "OfferId";
            ddlOffer.DataTextField = "OfferName";
            ddlOffer .DataBind();
            ddlOffer.Items.Insert(0, "---Select Offer---");

        }

        private void Bindcolor()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@ColorId", "0");
            nv.Add("@ColorName", "");

            dt = ObjGn.GetDataTable("Get_Color", nv);

            ddlcolor.DataSource = dt;
            ddlcolor.DataValueField = "ColorId";
            ddlcolor.DataTextField = "ColorName";
            ddlcolor .DataBind();
            ddlcolor.Items.Insert(0, "---Select Color---");

        }

        private  void BindProduct()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@ProductId", "0");
            nv.Add("@ProductName", "");

            dt = ObjGn.GetDataTable("", nv);

            
            
        }
    }
}