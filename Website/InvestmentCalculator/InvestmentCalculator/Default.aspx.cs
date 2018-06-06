using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvestmentCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            for (int i = 50; i <=500; i+=50)
            {
                ddlInvest.Items.Add(i.ToString());
            }
            
        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            int years = int.Parse(txtYears.Text);
            decimal yearlyInterestRate = decimal.Parse(txtRate.Text);
            int monthlyInvest = int.Parse(ddlInvest.SelectedValue);

            decimal investment = CalculateValue(monthlyInvest, yearlyInterestRate, years);
            lblResult.Text = "Hello " + txtName.Text + "\n" + 
                "The investment would be = " + investment.ToString(".00");
        }

        protected decimal CalculateValue(int monthlyInvestment, decimal yearlyInterestRate, int years)
        {
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 +
                monthlyInterestRate);
            }
            return futureValue;
        }

        /**
        * Form clearing function
        * Clear all data in the form
        * */
        private void clearForm()
        {
            txtName.Text = "";
            txtRate.Text = "";
            //txtName.Text=string.Empty; --->>> another way to clear it
            txtYears.Text = string.Empty;
            ddlInvest.ClearSelection();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
            txtName.Focus();
        }
    }


}
