using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Exam1.BAL;
using Exam1.Data;

namespace Exam1
{
    public partial class SupplierSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                
            }
        }

        //redirection from the Company name
        protected void ddlCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCompanyName.SelectedItem!=null)
            Response.Redirect("~/NewProduc.aspx?supplierID=" + Server.UrlEncode(ddlCompanyName.SelectedValue.ToString()));
        }

        //redirection from the suppliers list
        protected void gvSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvSuppliers.DataKeyNames != null)
                Response.Redirect("~/NewProduc.aspx?supplierID=" + Server.UrlEncode(gvSuppliers.SelectedValue.ToString()));
        }
    }
}