using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindDB
{
    public partial class Advanced_Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            //SELECT * FROM [Customers] WHERE ([CustomerID] = @CustomerID)
            SQLdsAllCustomer.SelectCommand = 
                "SELECT * FROM [Customers] WHERE ([" +
                ddlField.SelectedValue 
                +"] = @CustomerID)";
        }

    }
}