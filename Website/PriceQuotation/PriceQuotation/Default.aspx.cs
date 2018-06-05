using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PriceQuotation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrice.Text, out float price)&& float.TryParse(txtPercent.Text, out float percent))
            {
                float amount = price * percent / 100;
                lblAmount.Text = amount.ToString();
                lblTotal.Text = (price - amount).ToString();
            }
            else
            {
                txtPrice.Text = txtPercent.Text= "It has to be a positive number";
               
            }
            
        }
    }
}