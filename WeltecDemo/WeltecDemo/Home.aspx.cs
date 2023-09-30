using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeltecDemo.MyClass;

namespace WeltecDemo
{
    public partial class Home : System.Web.UI.Page
    {

        ClassHome objCh = new ClassHome();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            lblResult.Text = Sum(Convert.ToDecimal(txtNo1.Text), Convert.ToDecimal(txtNo2.Text)).ToString();

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            lblResult.Text = Sub(Convert.ToDecimal(txtNo1.Text), Convert.ToDecimal(txtNo2.Text)).ToString();
        }

        protected void btnMulty_Click(object sender, EventArgs e)
        {
            lblResult.Text = Multy(Convert.ToDecimal(txtNo1.Text), Convert.ToDecimal(txtNo2.Text)).ToString();
        }
        public decimal Sum(decimal NO1, decimal NO2)
        {
            decimal C = 0;
            C= objCh.Sum(NO1, NO2);
            return C;
        }
        public decimal Sub(decimal NO1, decimal NO2)    
        {

            decimal C = 0;
            C = objCh.Sub(NO1, NO2);
            return C;
        }
        public decimal Multy(decimal NO1, decimal NO2) 
        {
            decimal C= 0;
            C=objCh.Multy(NO1, NO2);
            return C;        
        }

    }
}