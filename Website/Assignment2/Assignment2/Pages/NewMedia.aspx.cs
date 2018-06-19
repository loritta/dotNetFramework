using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.Models;

namespace Assignment2.Pages
{
    public partial class NewMedia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Media m = new Media();
            m.Title = tbTitle.Text;
            m.MType = tbType.Text;
            m.ProductionYear = DateTime.Parse(tbYear.Text);
            VideoRentalStoreRepository r = new VideoRentalStoreRepository();
            r.AddNewMedia(m);
            Response.Redirect("~/Pages/Home.aspx");
        }
    }
}