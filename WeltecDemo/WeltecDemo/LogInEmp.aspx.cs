using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeltecDemo.MyClass;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Web.Services.Protocols;

namespace WeltecDemo
{
    public partial class LogInEmp : System.Web.UI.Page
    {
        General objGn = new General();

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@EmailId",txtEmail.Text);
                nv.Add("@UserName", txtUsername.Text);
                nv.Add("@Password", txtPswd.Text);

                dt = objGn.GetDataTable("GET_Login", nv);

                if (dt != null && dt.Rows.Count > 0)
                {
                   SendMail("Email" ,"Username", "Password");
                

                    Session["Name"] = dt.Rows[0]["UserName"].ToString(); 
                    Response.Redirect("DashBoard.aspx");

                    


                    lblmsg.Text = "LogIn Successfully...!";


                }
                else
                {

                    lblmsg.Text = "Invalid Username password";

                }

            
        }
        public int SendMail(string Email, string Username, string Password)
        {
            int IsReturn = 0;
            try
            {
                string EmailFromAddress = ConfigurationManager.AppSettings["EmailFromAddress"].ToString();
                string EmailPassword = ConfigurationManager.AppSettings["EmailPassword"].ToString();

                var fromAddress = EmailFromAddress;

                var toAddress = Email;

                string fromPassword = EmailPassword;
                // Passing the values and make a email formate to display
                string subject = "Your UserName and Password For ";
                string body = "Dear ," + "\n";
                body += "Your UserName and Password For Test:" + "\n";
                body += "UserName : " + Username + " " + "\n\n";
                body += "Password : " + Password + " " + "\n\n";
                body += "Link : https://Url" + "\n\n";
                body += "Thank you!" + "\n";
                body += "Warm Regards," + "\n";

                // smtp settings
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                    smtp.Timeout = 50000;
                }
                // Passing values to smtp object
                smtp.Send(fromAddress, toAddress, subject, body);
                IsReturn = 1;
            }
            catch (Exception ex)
            {
                //objGeneral.ErrorMessage("Error is=" + Convert.ToString(ex.Message));
                throw ex;
            }
            return IsReturn;
        }
    }    
}