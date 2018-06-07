using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quotation_Builder
{
    public partial class Index : System.Web.UI.Page
    {
        //

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double price = double.Parse(txtSalesPrice.Text);
            double discount = double.Parse(txtPercent.Text);

            double discountAmount = (price * discount / 100);
            lblDiscountAmount.Text = discountAmount.ToString();

            lblTotalPrice.Text = (price - discountAmount).ToString();
        }
    }
}