using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.Models;



namespace Assignment2.Pages
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; 

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            
            customer.FirstName = tbFName.Text;
            customer.LastName = tbLName.Text;
            customer.Address = tbAddress.Text;
            customer.PhoneNumber = tbPhoneNumber.Text;
            VideoRentalStoreRepository r = new VideoRentalStoreRepository();
            r.AddNewCustomer(customer);
            Response.Redirect("~/Pages/Home.aspx");

        }
    }
}