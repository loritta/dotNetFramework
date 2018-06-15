using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class HTTP_Stateless : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                txtCount.Text = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count++;
            txtCount.Text = count.ToString();
        }
    }
}