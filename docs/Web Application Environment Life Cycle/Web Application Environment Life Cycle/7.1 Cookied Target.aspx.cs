using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class Cookied_Target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInformation"];
            if (cookie != null)
            {
                lblName.Text = cookie["name"];
                lblEmail.Text = cookie["email"];
            }
        }
    }
}