using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class QS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect(
                "~/8.1 QS_Target.aspx?name=" +
                Server.UrlEncode(txtName.Text) +
                "&email=" +
                Server.UrlEncode(txtEmail.Text) 
                );
        }
    }
}