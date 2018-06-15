using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam1
{
    public partial class NewProduc : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings
           ["NORTHWNDConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            //Creating variables for the values to be inserted in the table

            int supplierID = int.Parse(Request.QueryString["supplierID"]);
            int categoryID = int.Parse(ddlSQLDSCategories.SelectedValue);
            string name = tbName.Text;
            string qPerUnit = tbQuantity.Text;
            double unitPrice = double.Parse(tbPricePerUnit.Text);
            int inStock = int.Parse(tbUnitsInStock.Text);
            int onOrderk = int.Parse(tbUnitOnOrder.Text);
            int orderLevel = int.Parse(tbOrderLevel.Text);
            bool discont = cbDiscont.Checked;


            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string sqlQuery = "Insert into Products (ProductName, SupplierID, CategoryID, " +
                        "QuantityPerUnit, UnitPrice, UnitsInStock, " +
                        "UnitsOnOrder, ReorderLevel, Discontinued) " +
                        "VALUES('" + name + "','" + supplierID + "','" + categoryID + "','" +
                        qPerUnit + "','" + unitPrice + "','" + inStock + "','" +
                        onOrderk + "','" + orderLevel + "','" + discont + "')";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Product added succesfully";
                    if (btnAddNew.Visible == true)
                    {
                        btnAddNew.Visible = false;
                    }
                    if (hlSupplierSearch.Visible == false)
                    {
                        hlSupplierSearch.Visible = true;
                    }

                }
                catch (Exception er)
                {
                    lblResult.Text = er.Message;
                }
            }
        }
    }
}