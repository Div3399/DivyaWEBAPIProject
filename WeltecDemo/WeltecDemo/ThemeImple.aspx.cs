using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Specialized;
using System.Data.SqlClient;
using WeltecDemo.MyClass;
using System.Collections;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Runtime.Remoting;
using System.IO;


namespace WeltecDemo
{
    public partial class ThemeImple : System.Web.UI.Page
    {
        General objGa = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            {
                BindBranch();
                BindRole();
                BindHobbies();
                BindEmpDetails();
            }
        }

        private long EmployeeId
        {

            get
            {
                if (ViewState["EmployeeId"] != null)
                {
                    return (long)ViewState["EmployeeId"];
                }
                return 0;
            }
            set
            {
                ViewState["EmployeeId"] = value;
            }
        }



        public void BindBranch()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();

            nv.Add("@BranchId", "0");
            nv.Add("@BranchName", "");


            dt = objGa.GetDataTable("GET_Branch", nv);

            ddlBranch.DataSource = dt;
            ddlBranch.DataValueField = "BranchId";
            ddlBranch.DataTextField = "BranchName";
            ddlBranch.DataBind();
            ddlBranch.Items.Insert(0, "---Select Branch---");
            

        }

        public void BindRole()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@RoleId", "0");
            nv.Add("@RoleName", "");

            dt = objGa.GetDataTable("GET_Role", nv);

            ddlRole.DataSource = dt;
            ddlRole.DataValueField = "RoleId";
            ddlRole.DataTextField = "RoleName";
            ddlRole.DataBind();
            ddlRole.Items.Insert(0, "---Select Role---");
            
        }

        public void BindHobbies()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@HobbiesId", "0");
            nv.Add("@HobbiesName", "");

            dt = objGa.GetDataTable("Get_Hobbies", nv);

            ChckHobbies.DataSource = dt;
            ChckHobbies.DataValueField = "HobbiesId";
            ChckHobbies.DataTextField = "HobbiesName";
            ChckHobbies.DataBind();
        }

        public void BindEmpDetails()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@EmployeeId", "0");
            nv.Add("@FirstName", txtSearch.Text);
            nv.Add("@Mode", "1");


            dt = objGa.GetDataTable("GET_Employee", nv);

            EmpDetails.DataSource = dt;
            EmpDetails.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string EMP = "";


            for (int i = 0; i < ChckHobbies.Items.Count; i++)
            {

                if (ChckHobbies.Items[i].Selected)
                {
                    EMP += ChckHobbies.Items[i].Value + ",";
                }

            }
            if (EMP != "")
            {
                EMP = EMP.Remove(EMP.Length - 1);
            }



            int Isresult = 0;

            NameValueCollection nv = new NameValueCollection();
            nv.Add("@EmployeeId", EmployeeId.ToString());
            nv.Add("@EmployeeNo", txtEmpNo.Text);
            nv.Add("@FirstName", txtFname.Text);
            nv.Add("@LastName", txtlname.Text);
            nv.Add("@Gender", rdbtn.Text);
            nv.Add("@BirthDate", txtBirth.Text);
            nv.Add("@JoiningDate", txtjoining.Text);
            nv.Add("@MobileNo", txtMobile.Text);
            nv.Add("@HomeMobileNo", txtHoMoNo.Text);
            nv.Add("@EmailId", txtemailId.Text);
            nv.Add("@Address", txtCuAdd.Text);
            nv.Add("@BranchId", ddlBranch.SelectedValue);
            nv.Add("@RoleId", ddlRole.SelectedValue);
            nv.Add("@HobbiesId", EMP);




            Isresult = objGa.GetDataExecuteScaler("SET_AddEmployee", nv);

            if (Isresult > 0)
            {
                lblmsg.Text = "Register Successfully..!";
                PanelADD.Visible = false;
                Panellist.Visible = true;
            }
            else
            {
                lblmsg.Text = "NotRegister...!";

            }

        }

        public void UploadImageProfile()
        {

            string filename = "", newfile = "";
            string[] validFileTypes = { "jpeg", "png", "jpg", "bmp", "gif" };

            if (!FileUpload1.HasFile)
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select a file.');", true);
                FileUpload1.Focus();
            }

            string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName).ToLower();
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

                if (FileUpload1.HasFile)
                {

                    filename = Server.MapPath(FileUpload1.FileName);
                    newfile = FileUpload1.PostedFile.FileName;
                    // filecontent = System.IO.File.ReadAllText(filename);
                    FileInfo fi = new FileInfo(newfile);

                    // check folder exist or not
                    if (!System.IO.Directory.Exists(@"~\Image\"))
                    {
                        try
                        {
                            NameValueCollection nv = new NameValueCollection();
                            nv.Add("@EmployeeID", "0");

                            int PID = objGa.GetDataExecuteScaler("GET_Image", nv);

                            string Imgname = "Profile" + PID + txtFname.Text;

                            string path = Server.MapPath(@"~\Image\");
                            System.IO.Directory.CreateDirectory(path);
                            FileUpload1.SaveAs(path + @"\" + "Profile" + PID + txtFname.Text + ext);

                            Image1.ImageUrl = @"~\Image\" + "Profile" + PID + txtFname.Text + ext;
                            FileUpload1.Visible = true;

                            lblImg.Text = Imgname + ext;


                            //  IdentityPolicyImageUrl = Imgname + ext;


                        }
                        catch (Exception ex)
                        {
                            lblImg.Text = "Not Created";
                        }

                    }
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select valid file.');", true);
            }


        }


        public void UploadDocument()
        {

            string filename = "", newfile = "";
            string[] validFileTypes = { "pdf", "word" };

            if (!FileUpload2.HasFile)
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select a file.');", true);
                FileUpload2.Focus();
            }

            string ext = System.IO.Path.GetExtension(FileUpload2.PostedFile.FileName).ToLower();
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

                if (FileUpload2.HasFile)
                {

                    filename = Server.MapPath(FileUpload2.FileName);
                    newfile = FileUpload2.PostedFile.FileName;
                    // filecontent = System.IO.File.ReadAllText(filename);
                    FileInfo fi = new FileInfo(newfile);

                    // check folder exist or not
                    if (!System.IO.Directory.Exists(@"~\Documents\"))
                    {
                        try
                        {
                            NameValueCollection nv = new NameValueCollection();
                            nv.Add("@EmployeeID", "0");

                            int PID = objGa.GetDataExecuteScaler("GET_Image", nv);

                            string Imgname = "Profile" + PID + txtFname.Text;

                            string path = Server.MapPath(@"~\Documents\");
                            System.IO.Directory.CreateDirectory(path);
                            FileUpload2.SaveAs(path + @"\" + "Profile" + PID + txtFname.Text + ext);

                            Image2.ImageUrl = @"~\Documents\" + "Profile" + PID + txtFname.Text + ext;
                            FileUpload2.Visible = true;

                            lbldoc.Text = Imgname + ext;


                            //  IdentityPolicyImageUrl = Imgname + ext;


                        }
                        catch (Exception ex)
                        {
                            lbldoc.Text = "Not Created";
                        }

                    }
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(GetType(), "ShowAlert", "alert('Please select valid file.');", true);
            }


        }

        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            UploadImageProfile();
        }

        protected void BtnDoc_Click(object sender, EventArgs e)
        {
            UploadDocument();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindEmpDetails();
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindEmpDetails();
        }

        protected void EmpDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            EmpDetails.PageIndex = e.NewPageIndex;
            BindEmpDetails();

        }

        protected void EmpDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EmpDlt")
            {
                string EmpId = e.CommandArgument.ToString();
                int Isresult = 0;

                NameValueCollection nv = new NameValueCollection();
                nv.Add("@EmployeeId", EmpId);

                Isresult = objGa.GetDataExecuteScaler("SET_DeleteEmployee", nv);

                BindEmpDetails();
            }


            if (e.CommandName == "EmpEdit")
            {
                PanelADD.Visible = true;
                Panellist.Visible = false;

                string EmpId = e.CommandArgument.ToString();
                EmployeeId = Convert.ToInt32(EmpId);

                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@EmployeeId", EmpId);
                nv.Add("@FirstName", "");
                nv.Add("@Mode", "2");

                dt = objGa.GetDataTable("GET_Employee", nv);

                if (dt != null && dt.Rows.Count > 0)
                {
                    txtEmpNo.Text = dt.Rows[0]["EmployeeNo"].ToString();
                    txtFname.Text = dt.Rows[0]["FirstName"].ToString();
                    txtlname.Text = dt.Rows[0]["LastName"].ToString();
                    txtBirth.Text = dt.Rows[0]["BirthDate"].ToString();
                    txtMobile.Text = dt.Rows[0]["MobileNo"].ToString();
                    txtHoMoNo.Text = dt.Rows[0]["HomeMobileNo"].ToString();
                    txtemailId.Text = dt.Rows[0]["EmailId"].ToString();
                    txtCuAdd.Text = dt.Rows[0]["Address"].ToString();
                    txtjoining.Text = dt.Rows[0]["JoiningDate"].ToString();
                    ddlBranch.SelectedValue = dt.Rows[0]["BranchId"].ToString();
                    ddlRole.SelectedValue = dt.Rows[0]["RoleId"].ToString();
                    


                }

            }

           
           
          
        }
    }
    
}
