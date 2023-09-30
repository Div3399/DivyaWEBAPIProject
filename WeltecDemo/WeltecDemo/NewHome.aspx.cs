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
    public partial class NewHome : System.Web.UI.Page
    {
        General objG = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            // lblEmpId.Text= Session["EmpId"].ToString();
            //lblName.Text= Session["Name"].ToString();

            if (!IsPostBack) 
            {
                BindGridemployee();

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

        public void BindGridemployee()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@ID", "0");
            nv.Add("@first_name", txtSearch.Text);
            nv.Add("@Mode", "1");

            dt = objG.GetDataTable("GET_employeesData", nv);

            GridViewEmployees.DataSource = dt;

            GridViewEmployees.DataBind();

        }


        protected void GridViewEmployees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          GridViewEmployees.PageIndex= e.NewPageIndex;
            BindGridemployee();

        }

        protected void GridViewEmployees_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "DeleteEmp")
            {
                string EmpID = e.CommandArgument.ToString();

                int Isresult = 0;

                NameValueCollection nv = new NameValueCollection();
                nv.Add("@ID", EmpID);

                Isresult = objG.GetDataExecuteScaler("SET_EmployeeId", nv);
                BindGridemployee();
            }


            if (e.CommandName =="EditEmp")
            {
                PanelAdd.Visible = true;
                PanelList.Visible = false;

                string EmpID = e.CommandArgument.ToString();
                ID = Convert.ToInt32(EmpID);

                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@ID", EmpID);
                nv.Add("@first_name", "");
                nv.Add("@Mode", "2");


                dt = objG.GetDataTable("GET_employeesData", nv);

                if (dt != null && dt.Rows.Count>0)
                {
                    
                    txtFname.Text= dt.Rows[0]["first_name"].ToString();
                    txtLname.Text = dt.Rows[0]["last_name"].ToString();
                    txtphone.Text= dt.Rows[0]["phone"].ToString() ;
                }
            }


            if (e.CommandName== "ViewEmp")
            { 
                PanelView.Visible = true;
                PanelList.Visible = false;

                string EmpID = e.CommandArgument.ToString();

                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();

                nv.Add("@ID", EmpID);

                dt = objG.GetDataTable("SET_Employees", nv);

                if (dt != null && dt.Rows.Count > 0)
                {

                    lblfname.Text = dt.Rows[0]["first_name"].ToString();
                    lblLname.Text = dt.Rows[0]["last_name"].ToString();
                    lblphone.Text = dt.Rows[0]["phone"].ToString();
                }


            }
            
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindGridemployee();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = true;
            PanelList.Visible = false;

        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindGridemployee();
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            int Isresult = 0;
            NameValueCollection nv = new NameValueCollection();
            nv.Add("@ID", ID.ToString());
            nv.Add("@first_name", txtFname.Text);
            nv.Add("@last_name", txtLname.Text);
            nv.Add("@phone", txtphone.Text);

            Isresult = objG.GetDataExecuteScaler("SET_ADDemployees", nv);

            if (Isresult > 0)
            {
                BindGridemployee();
                lblmsg.Text = "Reg...!";
                txtFname.Text = "";
                txtLname.Text = "";
                txtphone.Text = "";
            }
            else
            {
                lblmsg.Text = "Not reg ...!";

            }

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = false;
            PanelList.Visible = true;

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            PanelView.Visible = false;
            PanelList.Visible = true;

        }
    }
}