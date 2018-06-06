using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userInformation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
/**
 * Submit buton handler
 * Reads from form writes into label
 * 
 */
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid) { 
            
            string name = tbName.Text;
            string dateBirth = tbDate.ToString();
            string email = tbEmail.Text;
            string province = ddlProvince.SelectedValue.ToString();
            string city = ddlCity.SelectedValue.ToString();

            string print = "Hello, " + name + 
                "\nYour date of birth is: " + dateBirth +
                "\nYour contact information is the following: " + 
                "\nEmail: " + email + 
                "\nProvince: " + province + 
                "\nCity: " + city;
            lblPrint.Text = "New record add succesfully! Number of records: "+ updateCounter();
            
           
            //add to the listbox
            lbRecord.Items.Add(print);
            
            //clear form
            clearForm();
        }
        }


        /**
         * Drop down menu for province
         * used to populate the city drop down menu
         * based on the province selected value
         * 
         */
        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCity.Items.Clear();
            string choice = ddlProvince.SelectedValue.ToString();

            switch (choice)
            {
                case "Quebec":
                    ddlCity.Items.Add("Please select a city");
                    ddlCity.Items.Add("Montreal");
                    ddlCity.Items.Add("Quebec");
                    ddlCity.Items.Add("Laval");
                    break;
                case "Ontario":
                    ddlCity.Items.Add("Please select a city");
                    ddlCity.Items.Add("Ottawa");
                    ddlCity.Items.Add("Toronto");
                    break;
                case "British Columbia":
                    ddlCity.Items.Add("Please select a city");
                    ddlCity.Items.Add("Victoria");
                    ddlCity.Items.Add("Vancouver");
                    break;
                default:
                    break;
            }
        }

        /**
         * Form clearing function
         * Clear all data in the form
         * */
         private void clearForm()
        {
            tbName.Text = "";
            tbEmail.Text = "";
            //txtName.Text=string.Empty; --->>> another way to clear it
            tbDate.Text=string.Empty;
            ddlProvince.ClearSelection();
            ddlCity.Items.Clear();
           
        }

        /**
         * Update hidden value html control
         * */
         private int updateCounter()
        {
            int counter = int.Parse(hidVal.Value.ToString());
            counter++;
            hidVal.Value = counter.ToString();
            return counter;
        }
       
    }
}