using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WeltecDemo.MyClass;
using System.Data.SqlClient;
using System.Data;
using System.Web.DynamicData;
using System.Collections.Specialized;

namespace WeltecDemo
{
    public partial class Register : System.Web.UI.Page
    {
        ClassPrac objCp = new ClassPrac();
        General objG = new General();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();
                BindBloodCheckbox();
                BindBlood();
                BindGridemployee();
                
            }

        }

         public void BindCountry()
        {
            DataTable dt = new DataTable();
            NameValueCollection nv = new NameValueCollection();

            nv.Add("@id", "0");
            nv.Add("@name", "");
            nv.Add("@Mode", "1");

            dt = objG.GetDataTable("CountryMaster1", nv);

            ddlCountry.DataSource = dt;
            ddlCountry.DataValueField = "CountryID";
            ddlCountry.DataTextField = "CountryName";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, "---Select Country---");

         }
         
   

        public void BindGridemployee()
        {
            string str = "";
            str = "select * from employees";

            SqlDataReader dr;
            dr = objCp.MyExecuteReader(str);

             GridviewEmdata.DataSource = dr;

            GridviewEmdata.DataBind();

        }


        public void BindBloodCheckbox()
        {
            string str = "";
            str = "select * from Bloodgroup where IsActive=1";

            SqlDataReader dr;
            dr = objCp.MyExecuteReader(str);

            CheckBoxblood.DataSource = dr;
            CheckBoxblood.DataValueField = "BloodGroupId";
            CheckBoxblood.DataTextField = "BgName";
            CheckBoxblood.DataBind();
        }



        public void BindBlood ()
        {
            string str = "";
            str = "select * from BloodGroup where IsActive=1";

            SqlDataReader dr;

            dr = objCp.MyExecuteReader(str);

            ddlBlood.DataSource = dr;
            ddlBlood.DataValueField = "BloodGroupId";
            ddlBlood.DataTextField = "BgName";
            ddlBlood.DataBind();
            ddlBlood.Items.Insert(0 ,"---Selectbloodgrouop--");

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-D0537QQO\\SQLEXPRESS;Initial Catalog=Weltec;Integrated Security=True");

            string str = "";
            str = "insert into employees (First_Name,Last_Name,Age,phone) values('" + txtFname.Text + "','" + txtLname.Text + "','" + txtAge.Text + "','" + txtphone + "')";

      
            con.Open();

            SqlCommand CMD = new SqlCommand(str, con);

            // insert,update,delete
            CMD.ExecuteNonQuery();

            lblmsg.Text = "REG...!";
            txtFname.Text = "";
            txtLname.Text = "";
            txtAge.Text = "";
            txtphone.Text = ""; 

        }

        protected void btnSubmitWithClass_Click(object sender, EventArgs e)
        {

            int IsCount = 0;

            IsCount = objCp.MyExecuteScalar("select Count(*) from employees where phone= '"+txtphone.Text+"'");

            if (IsCount == 0)
            {

                string str = "";
                str = "insert into employees (First_Name,Last_Name,Age,phone) values('" + txtFname.Text + "','" + txtLname.Text + "','" + txtAge.Text + "','" + txtphone + "')";


                int Isresult = 0;
                Isresult = objCp.MyExecuteNonQuery(str);
                if (Isresult == 0)
                {
                    lblmsg.Text = "REG...!";
                    txtFname.Text = "";
                    txtLname.Text = "";
                    txtAge.Text = "";
                    txtphone.Text = "";

                }
                else
                {
                    lblmsg.Text = "Not Reg ...!";

                }
            }
            else 
            {
                lblmsg.Text = " Not Reg phone no";
            }
           
        }

        protected void btSubSubmit_Click(object sender, EventArgs e)
        {
            int Isresult = 0;

            NameValueCollection nv = new NameValueCollection();

            nv.Add("@ID ", "0");
            nv.Add("@first_name", txtFname.Text);
            nv.Add("@last_name", txtLname.Text);
            nv.Add("@age", txtAge.Text);
            nv.Add("@phone", txtphone.Text);
           


            Isresult = objG.GetDataExecuteScaler("SEt_ADDemployees", nv);

            if (Isresult > 0)
            {
                BindGridemployee();

                lblmsg.Text = "REG...!";
                txtFname.Text = "";
                txtLname.Text = "";
                txtAge.Text = "";
                txtphone.Text = "";

            }
            else
            {
                lblmsg.Text = "Not Reg ...!";

            }



        }
    }
}