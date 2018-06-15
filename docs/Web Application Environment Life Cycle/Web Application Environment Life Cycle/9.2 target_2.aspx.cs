using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class target_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previosPage = Page.PreviousPage;
            if(previosPage != null)
            {
                lblName.Text = ((TextBox)previosPage.FindControl("txtName")).Text;
                lblEmail.Text = ((TextBox)previosPage.FindControl("txtEmail")).Text;
            }
        }
    }
}