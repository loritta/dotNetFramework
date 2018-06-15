using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                txtCount.Text = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ViewState["Clicks"] == null)
            {
                ViewState["Clicks"] = 1;
            }
            txtCount.Text = ViewState["Clicks"].ToString();
            ViewState["Clicks"] = (int)ViewState["Clicks"] + 1;
        }

        protected void btnIncrement0_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtCount.Text);
            txtCount.Text = (count + 1).ToString();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}