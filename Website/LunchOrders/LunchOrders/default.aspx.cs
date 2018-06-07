using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LunchOrders
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 1;
            if (Page.IsPostBack)
                count += 1;
            lblOrderNumber.Text = count.ToString();
            if (!Page.IsPostBack)
            {
                
                lblOrderNumber.Text = count.ToString();
                //List Box Binding: Array of towns, where each town has an ID and a name

                var towns = new[]
            {
                    new{ID=1, Name="Montreal"},
                    new{ID=2, Name="Toronto"},
                    new{ID=3, Name="Laval"},
                    new{ID=4, Name="Ottawa"},
                    new{ID=5, Name="Vancouver"},
                };

                //1-source 2-binding
                lbCity.DataSource = towns;
                lbCity.DataBind();

                //Drop down list Gender binding

                var gender = new[]
                {
                new{ID=1, Name="Male"},
                new{ID=2, Name="Female"}
            };

                //1source 2 binding
                ddlGender.DataSource = gender;
                ddlGender.DataBind();

                //Meal Option binding to check box list
                var meal = new[]
               {
                    new{ID=1, Name="Burger"},
                    new{ID=2, Name="Steak"},
                    new{ID=3, Name="Salad"},
                    new{ID=4, Name="Nuggets"},
                    new{ID=5, Name="Sandwich"},
                };

                //1source 2 binding
                cblMeal.DataSource = meal;
                cblMeal.DataBind();


                //Payment Option binding to radio button list
                var payment = new[]
               {
                    new{ID=1, Name="Cash"},
                    new{ID=2, Name="Credit Card"},
                    new{ID=3, Name="Android pay"},
                    new{ID=4, Name="Apple pay"}

                };

                //1source 2 binding
                rblPayment.DataSource = payment;
                rblPayment.DataBind();
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Adding to the Order summary by creating a list
            var order = new[]
            {
                new{Value=lblOrderNumber.Text.ToString(), Text="Hello, "+tbName.Text+" !"},
               new{Value=lblOrderNumber.Text.ToString(), Text="Your order number is: "+lblOrderNumber.Text},
               new{Value=lbCity.SelectedValue.ToString(), Text="Your city is: "+lbCity.SelectedItem.ToString()},
               new{Value=ddlGender.SelectedValue.ToString(), Text="Your gender is: "+ddlGender.SelectedItem.ToString()},
               new{Value=cblMeal.SelectedValue.ToString(), Text="Your meal is: "+cblMeal.SelectedItem.ToString()},
               new{Value=rblPayment.SelectedValue.ToString(), Text="Your payment was done with: "+rblPayment.SelectedItem.ToString()}
               
           };

            //1source 2 binding
            lbOrder.DataSource = order;
            lbOrder.DataBind();
            clearForm();
        }

        protected void lbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void clearForm()
        {
            tbName.Text = string.Empty;
            ddlGender.ClearSelection();
            lbCity.ClearSelection();
            rblPayment.ClearSelection();
            cblMeal.ClearSelection();
        }
    }
}