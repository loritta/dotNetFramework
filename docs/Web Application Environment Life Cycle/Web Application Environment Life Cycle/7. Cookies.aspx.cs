using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the information from the form and add to a cookie
            HttpCookie cookie = new HttpCookie("UserInformation");
            cookie["name"] = txtName.Text;
            cookie["email"] = txtEmail.Text;
            //cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/7.1 Cookied Target.aspx");
        }
    }
}