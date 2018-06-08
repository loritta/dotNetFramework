using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLNorthwindDB
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SELECT * FROM [Customers] WHERE ([CustomerID] = @CustomerID)
            SQLAllCustomers.SelectCommand = "SELECT * FROM [Customers] WHERE ([" + DropDownList1.SelectedValue + "] = @CustomerID)";
        }
    }
}