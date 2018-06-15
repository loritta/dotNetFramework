using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                txtCount.Text = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Application["Clicks"] == null)
            {
                Application["Clicks"] = 1;
            }
            txtCount.Text = Application["Clicks"].ToString();
            Application["Clicks"] = (int)Application["Clicks"] + 1;
        }
    }
}