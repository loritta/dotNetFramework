using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADONET_Demo
{
    
    public partial class Orders_Search : System.Web.UI.Page
    {
        //Connection string
        private string conString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString_ADO"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "select * from Orders where OrderID =" + txtOrderID.Text;
            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;
                con.Open();

                reader = cmd.ExecuteReader();

                dvOrder.DataSource = reader;
                dvOrder.DataBind();
                reader.Close();
                /*  Get either customer or shipper
                 *  The switch will build the query for customer details or shipper
                 *  after that the command will be executed.
                 */
                switch (ddlOptions.SelectedValue)
                {
                    case "Customers":
                        //getting the customerID from the details view.
                        //string customerID = dvOrder.Rows[1].Cells[1].Text;
                        string customerID ="";
                        for (int i = 0; i < dvOrder.Rows.Count; i++)
                        {
                            if(dvOrder.Rows[i].Cells[0].Text == "CustomerID")
                                customerID = dvOrder.Rows[i].Cells[1].Text;
                        }
                        query = "select * from Customers where CustomerID='" + customerID + "'";
                        break;
                    case "Shippers":
                        //string shipperID = dvOrder.Rows[6].Cells[1].Text;
                        string shipperID = "";
                        for (int i = 0; i < dvOrder.Rows.Count; i++)
                        {
                            if (dvOrder.Rows[i].Cells[0].Text == "ShipVia")
                                shipperID = dvOrder.Rows[i].Cells[1].Text;
                        }
                        query = "select * from Shippers where ShipperID=" + shipperID;
                        break;
                }

                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                reader.Read();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    lbOption.Items.Add(reader.GetName(i) + ". " + reader[i].ToString());
                }

                con.Close();
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }
}