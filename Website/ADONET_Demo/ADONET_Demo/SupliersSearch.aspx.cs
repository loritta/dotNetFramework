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
    public partial class SupliersSearch : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings
            ["NORTHWNDConnectionString_ADO"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
            if (!Page.IsPostBack)
            {

            }
            //Populate my drop down list 
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                string sqlQuery = "select * from Suppliers";
                //lblConnection.Text = "Connection established... :)";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ListItem selectItem = new ListItem();
                selectItem.Text = "Please select a supplier";
                selectItem.Value = "";
                ddlSuppliers.Items.Add(selectItem);
                while (reader.Read())
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = reader["SupplierID"]+"."+reader["CompanyName"];
                    newItem.Value = reader["SupplierID"].ToString();
                    ddlSuppliers.Items.Add(newItem);
                    
                }
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection error... :(" + er.Message;
            }
            finally
            {
                con.Close();
                //lblConnection.Text += "...Now the connection is closed..";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                lbSuppliers.Items.Clear();
                string sqlQuery = "select * from Suppliers where SupplierID =" + tbSupplier.Text;
                //lblConnection.Text = "Connection established... :)";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbSuppliers.Items.Add("ID: " + reader["SupplierID"]);
                    lbSuppliers.Items.Add("Name: " + reader["CompanyName"]);
                    lbSuppliers.Items.Add("Address: " + reader["Address"]);
                    lbSuppliers.Items.Add("Phone: " + reader["Phone"]);
                }
                else
                    lbSuppliers.Items.Add("No Record found");
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection error... :("+er.Message;
            }
            finally
            {
                con.Close();
                //lblConnection.Text += "...Now the connection is closed..";
            }
        }

        protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                if (ddlSuppliers.SelectedIndex != 0)
                {
                    string sqlQuery = "select * from Suppliers where SupplierID =" + ddlSuppliers.SelectedValue;

                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dvSupplier.DataSource = reader;
                    dvSupplier.DataBind();
                }
                else
                {
                    dvSupplier.DataSource = null;
                    dvSupplier.DataBind();
                }
                
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection error... :(" + er.Message;
            }
            finally
            {
                con.Close();
                //lblConnection.Text += "...Now the connection is closed..";
            }
        }
    }
}
/**
 * 
            SqlConnection con = new SqlConnection(ConString);
            try
            {
                con.Open();
                lblConnection.Text = "Connection established... :)";
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection error... :(";
            }
            finally
            {
                con.Close();
                lblConnection.Text += "...Now the connection is closed..";
            }
*/