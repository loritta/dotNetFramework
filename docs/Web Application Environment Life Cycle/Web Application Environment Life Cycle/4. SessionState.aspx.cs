using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class SessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["visits"] == null)
            {
                Session["visits"] = 1;
                Label1.Text = "This is your first visit..";
            }
            else
            {
                Session["visits"] = (int)Session["visits"] + 1;
                Label1.Text = "Welcome back.. visit #" + Session["visits"];
            }
            if (!Page.IsPostBack)
            {
                txtCount.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Clicks"] == null)
            {
                Session["Clicks"] = 1;
            }
            txtCount.Text = Session["Clicks"].ToString();
            Session["Clicks"] = (int)Session["Clicks"] + 1;
        }
    }
}