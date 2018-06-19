using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.Models;

namespace Assignment2.Pages
{
    public partial class RentMedia : System.Web.UI.Page
    {
        protected List<Media> lMedia;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbSearch_TextChanged(object sender, EventArgs e)
        {
            cblResult.DataSource = null;
            cblResult.DataBind();
            VideoRentalStoreRepository v = new VideoRentalStoreRepository();
            lMedia =v.getMediaTitle(tbSearchTitle.Text);
            cblResult.DataSource = lMedia;
            cblResult.DataBind();
        }


        protected void tbSearchType_TextChanged(object sender, EventArgs e)
        {
            cblResult.DataSource = null;
            cblResult.DataBind();
            VideoRentalStoreRepository v = new VideoRentalStoreRepository();
            lMedia = v.getMediaType(tbSearchType.Text);
            cblResult.DataSource = lMedia;
            cblResult.DataBind();
        }


        protected void btnRentMedia_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["customerID"] == null)
            {
                string message = "You need to select a customer first. Please Select a Customer";
                Response.Redirect("~/Pages/Customers.aspx?message=" + Server.UrlEncode(message));
               
            }
            else
            {
                int customerID = int.Parse(Request.QueryString["customerID"]);
                VideoRentalStoreRepository v = new VideoRentalStoreRepository();
                List<int> mediaID = new List<int>();
                if (cblResult.Items.Count != 0)
                {
                    foreach (ListItem lst in cblResult.Items)
                    {
                        if (lst.Selected == true)
                        {
                            mediaID.Add(int.Parse(lst.Value));
                        }
                    }
                    v.AddRentalRecord(customerID, mediaID);
                }
                else
                {
                    Response.Write("There is no infromation to register.");
                };
               
               

            }
        }
        
    }
}