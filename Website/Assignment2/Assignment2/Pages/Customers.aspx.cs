using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2.Pages
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["message"] == null)
                    return;
                else
                {
                    string message = Request.QueryString["message"];
                    Response.Write(message);
                }
            }
        }

        protected void btnRentMedia_Click(object sender, EventArgs e)
        {
                Response.Redirect("~/Pages/RentMedia.aspx?customerID=" + Server.UrlEncode(gvCustomers.SelectedValue.ToString()));
        }
    }
}