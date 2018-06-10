using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckOutPage
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Binding the provinces to the drop down list in billing and shipping
                var province = new[]
                {
                    new{ID=1, Name="ALBERTA"},
                    new{ID=2, Name="BRITISH COLUMBIA"},
                    new{ID=3, Name="MANITOBA"},
                    new{ID=4, Name="NEW BRUNSWICK"},
                    new{ID=5, Name="NEWFOUNDLAND and LABRADOR "},
                    new{ID=6, Name="NOVA SCOTIA "},
                    new{ID=7, Name="NUNAVUT"},
                    new{ID=8, Name="ONTARIO"},
                    new{ID=9, Name="PRINCE EDWARD ISLAND"},
                    new{ID=10, Name="QUEBEC"},
                    new{ID=11, Name="SASKATCHEWAN"},
                    new{ID=12, Name="YUKON"},
                };
                ddlShipState.DataSource = province;
                ddlShipState.DataBind();
                ddlState.DataSource = province;
                ddlState.DataBind();
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            //choosing the address information to be displayed in the result
            string shippingAddress, shippingCity, shippingState, shippingZip;
            if (cbShippingAddress.Checked)
            {
               shippingAddress = tbAddress.Text;
                shippingCity = tbCity.Text;
                shippingState = ddlState.SelectedItem.ToString();
                shippingZip = tbZip.Text;
            }
            else
            {
                shippingAddress = tbShipAddress.Text;
                shippingCity = tbShipCity.Text;
                shippingState = ddlShipState.SelectedItem.ToString();
                shippingZip = tbShipZip.Text;
            }
            //seting the result field visible and printing the information to the list box
            lbResult.Visible = true;

            lbResult.Text=
                "Your name is: " + tbFName.Text+" " + tbLName + Environment.NewLine +
                "Your Email address is: " + tbEmail + Environment.NewLine+
                "Your Phone number is: " + tbPhone + Environment.NewLine+
                 Environment.NewLine +
                "Your billing information is: " + Environment.NewLine +
                "Address: "+tbAddress.Text+Environment.NewLine +
                "City: "+tbCity.Text+Environment.NewLine +
                "State: "+ddlState.SelectedItem.ToString()+Environment.NewLine +
                "Zip code: "+tbZip.Text+Environment.NewLine +
                 Environment.NewLine +
                "Your Shipping information is: " + Environment.NewLine +
                "Address: "+shippingAddress+Environment.NewLine +
                "City: "+shippingCity+Environment.NewLine +
                "State: "+shippingState+Environment.NewLine +
                "Zip code: "+shippingZip+Environment.NewLine;
            clearForm();
        }

        /**
         * Change the displaying of the shipping address part in function
         * of the choice of the customer
         * */
        protected void cbShippingAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShippingAddress.Checked)
            {
                tbShipAddress.Visible = false;
                tbShipCity.Visible = false;
                tbShipZip.Visible = false;
                ddlShipState.Visible = false;
                rfvSAddress.Enabled = true;
                rfvSCity.Enabled = true;
                rfvSState.Enabled = true;
                revShipZip.Enabled = true;
          
            }
            else
            {
                tbShipAddress.Visible = true;
                tbShipCity.Visible = true;
                tbShipZip.Visible = true;
                ddlShipState.Visible = true;
                rfvSAddress.Enabled = false;
                rfvSCity.Enabled = false;
                rfvSState.Enabled = false;
                revShipZip.Enabled = false;
            }
        }
        /**
         * Clear the form function to be applyed after submitting.
         */
        private void clearForm()
        {
            tbFName.Text = tbLName.Text = tbPhone.Text= tbEmail.Text =tbReEmail.Text = string.Empty;
            tbAddress.Text = tbZip.Text = tbCity.Text = string.Empty;
            ddlShipState.ClearSelection();
            ddlState.ClearSelection();
            cbShippingAddress.Checked = false;
        }
    }
}