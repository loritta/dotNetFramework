using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Step 1 - ADD NAME SPACES TO USE
using System.Data;
using System.Data.SqlClient;
using System.Configuration; //this provides access to web.config

namespace ADONET_Demo
{
    public partial class OrderDetailsSearch : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings
           ["NORTHWNDConnectionString_ADO"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Drop down list Gender binding

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lbxCustomerShipper.Items.Clear();
            dvOrder.DataSource = null;
            dvOrder.DataBind();

            string query = "select * from Orders where OrderID =" + tbOrderID.Text;
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;
                con.Open();

                reader = cmd.ExecuteReader();
                dvOrder.DataSource = reader;
                dvOrder.DataBind();
                reader.Close();
                switch (ddlCustomerShipper.SelectedValue)
                {
                    case "Customer":
                        string customerID = dvOrder.Rows[1].Cells[1].Text;
                        query = "select * from Customers where CustomerID='" + customerID + "'";
                        break;
                    case "Shipper":
                        string shipperID = dvOrder.Rows[6].Cells[1].Text;
                        query = "select * from Shippers where ShipperID =" + shipperID;
                        break;
                    default:
                        lbxCustomerShipper.Items.Add("NO DATA TO DISPLAY");
                        break;
                }
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                reader.Read();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    lbxCustomerShipper.Items.Add(i + "." + reader[i].ToString());
                }

                        con.Close();
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection error... :(" + er.Message;
            }
           

        }

        protected void ddlCustomerShipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbxCustomerShipper.Items.Clear();
                SqlConnection con = new SqlConnection(ConString);
                string query = "";
                con.Open();
                switch (ddlCustomerShipper.SelectedValue)
                {
                    case "Customer":
                        string customerID = dvOrder.Rows[1].Cells[1].Text;
                        query = "select * from Customers where CustomerID='" + customerID + "'";
                        break;
                    case "Shipper":
                        string shipperID = dvOrder.Rows[6].Cells[1].Text;
                        query = "select * from Shippers where ShipperID =" + shipperID;
                        break;
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    lbxCustomerShipper.Items.Add(i + "." + reader[i].ToString());
                }

                con.Close();
            }
            catch(Exception)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection error... Customer/shipper details :(";
            }
        }
    }
}