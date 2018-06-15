using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class Application_Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of applications = " + Application["NumberofApplications"]);
            Response.Write("<br/>");
            Response.Write("Number of sessions = " + Application["NumberofSession"]);
        }
    }
}