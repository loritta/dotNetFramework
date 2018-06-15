using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Web_Application_Environment_Life_Cycle
{
    public class Global : System.Web.HttpApplication
    {
        /*Track number of:
         * 1- Applications
         * 2- Sessions
         */
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["NumberofApplications"] = 0;
            Application["NumberofSession"] = 0;

            Application["NumberofApplications"] = (int)Application["NumberofApplications"] + 1;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["NumberofSession"] = (int)Application["NumberofSession"] + 1;
        }
        protected void Session_End(object sender, EventArgs e)
        {
            Application["NumberofSession"] = (int)Application["NumberofSession"] - 1;
        }

    }
}