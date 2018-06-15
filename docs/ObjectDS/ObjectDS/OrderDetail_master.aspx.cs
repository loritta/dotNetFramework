using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObjectDS
{
    public partial class OrderDetail_master : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if(Request.QueryString["Print"] != null)
            {
                MasterPageFile = "~/Print.master";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}