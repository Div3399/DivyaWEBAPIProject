using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WeltechShopping.MyClass;

namespace WeltechShopping
{
    public partial class Product : System.Web.UI.Page
    {
        General objG = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindGV();
                bindBrand();
                bindCategory();
                bindColor();
                bindOffer();
                bindSubcategory();
            }
        }

        private int ProductId
        {
            get
            {
                if (ViewState["ProductId"] == null)
                {
                    return 0;
                }
                else
                {
                    return (int)ViewState["ProductId"];
                }
            }
            set
            {
                ViewState["ProductId"] = value;
            }
        }

        private string ProductImg
        {
            get
            {
                if (ViewState["ProductImg"] == null)
                {
                    return "";
                }
                else
                {
                    return (string)ViewState["ProductImg"];
                }
            }
            set
            {
                ViewState["ProductImg"] = value;
            }
        }

        private void clear()
        {
            txtProductName.Text = string.Empty;
            txtProductActualPrice.Text = string.Empty;
            txtProductLongDescription.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductSortDescription.Text = string.Empty;
            txtProductTotalQuantity.Text = string.Empty;
            txtSearchTerm.Text = string.Empty;
        }

        private void bindCategory()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@CategoryId", "0");
            nvc.Add("@Name", "");

            dt = objG.GetDataTable("GET_Category", nvc);
            ddlCategory.DataSource = dt;
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "CategoryId";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "Select");
        }
        private void bindSubcategory()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@SubCatId", "0");
            nvc.Add("@Name", "");

            dt = objG.GetDataTable("GET_SubCategory", nvc);
            ddlSubcategory.DataSource = dt;
            ddlSubcategory.DataTextField = "SubCatName";
            ddlSubcategory.DataValueField = "SubCatId";
            ddlSubcategory.DataBind();
            ddlSubcategory.Items.Insert(0, "Select");
        }

        private void bindBrand()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@BrandId", "0");
            nvc.Add("@Name", "");

            dt = objG.GetDataTable("GET_Brand", nvc);
            ddlBrand.DataSource = dt;
            ddlBrand.DataTextField = "BrandName";
            ddlBrand.DataValueField = "BrandId";
            ddlBrand.DataBind();
            ddlBrand.Items.Insert(0, "Select");
        }

        private void bindOffer()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@OfferId", "0");
            nvc.Add("@Name", "");

            dt = objG.GetDataTable("GET_Offers", nvc);
            ddlOffer.DataSource = dt;
            ddlOffer.DataTextField = "OfferName";
            ddlOffer.DataValueField = "OfferId";
            ddlOffer.DataBind();
            ddlOffer.Items.Insert(0, "Select");
        }
        private void bindColor()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@ColorId", "0");
            nvc.Add("@Name", "");

            dt = objG.GetDataTable("GET_Color", nvc);
            ddlColor.DataSource = dt;
            ddlColor.DataTextField = "ColorName";
            ddlColor.DataValueField = "ColorId";
            ddlColor.DataBind();
            ddlColor.Items.Insert(0, "Select");
        }
        private void bindGV()
        {
            DataTable dt = new DataTable();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@ProductId", ProductId.ToString());
            nvc.Add("@Name", txtSearchTerm.Text);

            dt = objG.GetDataTable("GET_Product", nvc);
            GVDisplay.DataSource = dt;
            GVDisplay.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("@ProductId", ProductId.ToString());
            nvc.Add("@CategoryId", ddlCategory.SelectedValue);
            nvc.Add("@SubCatId", ddlSubcategory.SelectedValue);
            nvc.Add("@BrandId", ddlBrand.SelectedValue);
            nvc.Add("@ColorId", ddlColor.SelectedValue);
            nvc.Add("@OffersId", ddlOffer.SelectedValue);
            nvc.Add("@ProductName", txtProductName.Text);
            nvc.Add("@ProductPrice", txtProductPrice.Text);
            nvc.Add("@SortDescription", txtProductSortDescription.Text);
            nvc.Add("@LongDescription", txtProductLongDescription.Text);
            nvc.Add("@ProductImage", ProductImg);
            nvc.Add("@TotalQuantity", txtProductTotalQuantity.Text);
            nvc.Add("@ActualPrice", txtProductActualPrice.Text);
            nvc.Add("@CreatedBy", ViewState["UserName"].ToString());
            nvc.Add("@UpdatedBy", ViewState["UserName"].ToString());
            nvc.Add("@IsActive", "1");

            int IsSuccess = 0;
            IsSuccess = objG.GetDataExecuteScaler("SET_AddProduct", nvc);
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
            bindGV();
            clear();
        }

        protected void GVDisplay_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditProduct")
            {
                ProductId = Convert.ToInt32(e.CommandArgument);
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("@ProductId", ProductId.ToString());
                nvc.Add("@Name", txtSearchTerm.Text);
                DataTable dt = new DataTable();
                dt = objG.GetDataTable("GET_Product", nvc);

                if (dt != null && dt.Rows.Count > 0)
                {
                    //[ProductId], [CategoryId], [SubCatId], [BrandId], [ColorId], [OffersId], [ProductName], [ProductPrice], [SortDescription], [LongDescription], [ProductImage], [TotalQuantity], [ActualPrice], [CreatedBy], [UpdatedBy], [IsActive]
                    bindCategory();
                    ddlCategory.SelectedIndex = Convert.ToInt32(dt.Rows[0]["CategoryId"]);
                    bindSubcategory();
                    ddlSubcategory.SelectedIndex = Convert.ToInt32(dt.Rows[0]["SubCatId"]);
                    bindBrand();
                    ddlBrand.SelectedIndex = Convert.ToInt32(dt.Rows[0]["BrandId"]);
                    bindColor();
                    ddlColor.SelectedIndex = Convert.ToInt32(dt.Rows[0]["BrandId"]);
                    bindOffer();
                    ddlOffer.SelectedIndex = Convert.ToInt32(dt.Rows[0]["OffersId"]);
                    txtProductName.Text = dt.Rows[0]["ProductName"].ToString();
                    txtProductPrice.Text = dt.Rows[0]["ProductPrice"].ToString();
                    txtProductSortDescription.Text = dt.Rows[0]["SortDescription"].ToString();
                    txtProductLongDescription.Text = dt.Rows[0]["LongDescription"].ToString();
                    txtProductTotalQuantity.Text = dt.Rows[0]["TotalQuantity"].ToString();
                    txtProductActualPrice.Text = dt.Rows[0]["ActualPrice"].ToString();
                    imgProductImage.ImageUrl = dt.Rows[0]["ProductImage"].ToString();
                }
            }
            else if (e.CommandName == "DeleteProduct")
            {
                ProductId = Convert.ToInt32(e.CommandArgument);
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("@ProductId", ProductId.ToString());

                int IsSuccess = objG.GetDataExecuteScaler("SET_DeleteProduct", nvc);
                bindGV();
            }
        }

        protected void GVDisplay_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVDisplay.PageIndex = e.NewPageIndex;
            bindGV();
        }

        protected void btnUploadImg_Click(object sender, EventArgs e)
        {
            string filename = "", newfile = "";
            string[] validFileTypes = { "jpeg", "png", "jpg", "bmp", "gif" };

            if (!fuProductImage.HasFile)
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select a file.');", true);
                fuProductImage.Focus();
            }

            string ext = System.IO.Path.GetExtension(fuProductImage.PostedFile.FileName).ToLower();
            bool isValidFile = false;
            for (int i = 0; i < validFileTypes.Length; i++)
            {
                if (ext == "." + validFileTypes[i])
                {
                    isValidFile = true;
                    break;
                }
            }
            if (isValidFile == true)
            {

                if (fuProductImage.HasFile)
                {

                    filename = Server.MapPath(fuProductImage.FileName);
                    newfile = fuProductImage.PostedFile.FileName;
                    //                filecontent = System.IO.File.ReadAllText(filename);
                    FileInfo fi = new FileInfo(newfile);

                    // check folder exist or not
                    if (!System.IO.Directory.Exists(@"~\App_Themes\ProductImages"))
                    {
                        try
                        {
                            NameValueCollection nvc = new NameValueCollection();
                            nvc.Add("@CustomerId", "");
                            nvc.Add("@CustomerName", "");
                            nvc.Add("@Count", "0");
                            DataTable dt = new DataTable();
                            dt = objG.GetDataTable("SP_GETCount", nvc);
                            //string Imgname = "Profile" + PID + txtFname.Text;
                            string Imgname = "";
                            if (dt != null && dt.Rows.Count > 0)
                            {

                                Imgname = txtProductName.Text + dt.Rows[0]["TotProduct"].ToString();
                            }
                            else
                            {
                                Imgname = txtProductName.Text + "1";
                            }

                            string path = Server.MapPath(@"~\App_Themes\ProductImages\");
                            System.IO.Directory.CreateDirectory(path);
                            fuProductImage.SaveAs(path + @"\" + Imgname + ext);

                            imgProductImage.ImageUrl = @"~\App_Themes\ProductImages\" + Imgname + ext;
                            imgProductImage.Visible = true;

                            lblImg.Text = Imgname + ext;

                            //  IdentityPolicyImageUrl = Imgname + ext;


                        }
                        catch (Exception ex)
                        {
                            LblMsg.Text = "Not able to create new directory";
                        }

                    }
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select valid file.');", true);
            }
        }

        protected void lnkbtnUpload_Click(object sender, EventArgs e)
        {
            string filename = "", newfile = "";
            string[] validFileTypes = { "jpeg", "png", "jpg", "bmp", "gif" };

            if (!fuProductImage.HasFile)
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select a file.');", true);
                fuProductImage.Focus();
            }

            string ext = System.IO.Path.GetExtension(fuProductImage.PostedFile.FileName).ToLower();
            bool isValidFile = false;
            for (int i = 0; i < validFileTypes.Length; i++)
            {
                if (ext == "." + validFileTypes[i])
                {
                    isValidFile = true;
                    break;
                }
            }
            if (isValidFile == true)
            {

                if (fuProductImage.HasFile)
                {

                    filename = Server.MapPath(fuProductImage.FileName);
                    newfile = fuProductImage.PostedFile.FileName;
                    //                filecontent = System.IO.File.ReadAllText(filename);
                    FileInfo fi = new FileInfo(newfile);

                    // check folder exist or not
                    if (!System.IO.Directory.Exists(@"~\App_Themes\ProductImages"))
                    {
                        try
                        {
                            NameValueCollection nvc = new NameValueCollection();
                            nvc.Add("@CustomerId", "");
                            nvc.Add("@CustomerName", "");
                            nvc.Add("@Count", "0");
                            DataTable dt = new DataTable();
                            dt = objG.GetDataTable("SP_GETCount", nvc);
                            //string Imgname = "Profile" + PID + txtFname.Text;
                            string Imgname = "";
                            if (dt != null && dt.Rows.Count > 0)
                            {

                                Imgname = txtProductName.Text + dt.Rows[0]["TotProduct"].ToString();
                            }
                            else
                            {
                                Imgname = txtProductName.Text + "1";
                            }

                            string path = Server.MapPath(@"~\App_Themes\ProductImages\");
                            System.IO.Directory.CreateDirectory(path);
                            fuProductImage.SaveAs(path + @"\" + Imgname + ext);
                            ProductImg = @"~\App_Themes\ProductImages\" + Imgname + ext;
                            imgProductImage.ImageUrl = @"~\App_Themes\ProductImages\" + Imgname + ext;
                            imgProductImage.Visible = true;

                            lblImg.Text = Imgname + ext;

                            //  IdentityPolicyImageUrl = Imgname + ext;


                        }
                        catch (Exception ex)
                        {
                            LblMsg.Text = "Not able to create new directory";
                        }

                    }
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select valid file.');", true);
            }
        }
    }
}