using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WeltecDemo.MyClass;

namespace WeltecDemo
{
    public partial class PracticeIUD : System.Web.UI.Page
    {
        General objGn = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmployees();
            
            }
        }

        private long ID
        {
            get 
            {
                if (ViewState["ID"] != null)
                {
                    return (long)ViewState["ID"];
                }
                return 0;
            }
            set 
            { 
                ViewState["ID"] = value; 
            
            }
        }


        public void BindEmployees()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@ID", "0");
            nv.Add("@first_name", txtSearch.Text);
            nv.Add("@Mode", "1");

            dt = objGn.GetDataTable("GET_Employees", nv);

            Employees.DataSource = dt;
            Employees.DataBind();
        }

        protected void Employees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Employees.PageIndex = e.NewPageIndex;
            BindEmployees();

        }

        protected void Employees_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DltId")
            {
                string empid = e.CommandArgument.ToString();
                int Isresult = 0;

                NameValueCollection nv = new NameValueCollection();
                nv.Add("@ID", empid);

                Isresult = objGn.GetDataExecuteScaler("SET_DeleteEmp", nv);
                BindEmployees();

            }


            if(e.CommandName == "EditId")
            {
                PanelADD.Visible = true;
                Panellist.Visible = false;

                string empid = e.CommandArgument.ToString();
                ID = Convert.ToInt32(empid);

                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@ID", empid);
                nv.Add("@first_name", "");
                nv.Add("@Mode", "2");


                dt = objGn.GetDataTable("GET_Employees", nv);
               
                if(dt != null && dt.Rows.Count>0) 
                {
                    txtFname.Text = dt.Rows[0]["first_name"].ToString();
                    txtlastname.Text = dt.Rows[0]["last_name"].ToString();
                    txtGender.Text = dt.Rows[0]["gender"].ToString();
                    txtAge.Text = dt.Rows[0]["age"].ToString();
                    txtphone.Text = dt.Rows[0]["phone"].ToString();

                }



            }

            if(e.CommandName == "ViewId")
            {
                PanelView.Visible = true;
                Panellist.Visible = false;

                string empid = e.CommandArgument.ToString();

                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@ID", empid );  

                dt = objGn.GetDataTable("SET_ViewEmp", nv);
               
                if (dt != null && dt.Rows.Count > 0)
                {
                    lblfname.Text = dt.Rows[0]["first_name"].ToString();
                    lblLname.Text = dt.Rows[0]["last_name"].ToString();
                    lblgen.Text = dt.Rows[0]["gender"].ToString();
                    lblage.Text = dt.Rows[0]["age"].ToString();
                    lblphn.Text = dt.Rows[0]["phone"].ToString();

                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int Isresult = 0;
            NameValueCollection nv= new NameValueCollection();
            nv.Add ("@ID", ID.ToString());
            nv.Add("@first_name",txtFname.Text);
            nv.Add("@last_name", txtlastname.Text);
            nv.Add("@gender", txtGender.Text);
            nv.Add("@age", txtAge.Text);
            nv.Add("@phone", txtphone.Text);

            Isresult = objGn.GetDataExecuteScaler("SET_ADDEmp", nv);

            if (Isresult > 0)
            {
                BindEmployees();
                lblmsg.Text = "Sucessfully..!";
                txtFname.Text = "";
                txtlastname.Text = "";
                txtGender.Text = "";
                txtAge.Text = "";
                txtphone.Text = "";
            }
            else
            {
                lblmsg.Text = "UnSucessfully...!";
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            PanelADD.Visible = false;
            Panellist.Visible = true;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindEmployees();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            PanelADD.Visible = true;
            Panellist.Visible = false;
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindEmployees();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            PanelView.Visible = false;
            Panellist.Visible = true;
        }
    }
}