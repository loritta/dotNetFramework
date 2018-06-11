using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//STEP 1 - ADD NAME SPACES
using System.Data;
using System.Data.SqlClient;
using System.Configuration; //This provides access to web.config
namespace ADONET_Demo
{
    public partial class Supplier_Search : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString_ADO"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (Page.IsPostBack)
                return;

            //Populate my drop down list
            SqlConnection con = new SqlConnection(ConString);
            try
            {
                string sqlQuery = "Select * from Suppliers";
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
                    newItem.Text = reader["SupplierID"] +". " + reader["CompanyName"];
                    newItem.Value = reader["SupplierID"].ToString();
                    ddlSuppliers.Items.Add(newItem);
                }
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection ERROR..... :( " + er.Message;
            }
            finally
            {
                con.Close();
                //lblConnection.Text += "  .. Now the connection is closed..";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            try
            {
                lbSuppliers.Items.Clear();
                string sqlQuery = "Select * from Suppliers where SupplierID =" + txtInput.Text;
                SqlCommand cmd = new SqlCommand(sqlQuery,con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lbSuppliers.Items.Add("ID: " + reader["SupplierID"]);
                    lbSuppliers.Items.Add("Name: " + reader["CompanyName"]);
                    lbSuppliers.Items.Add("Address: " + reader["Address"]);
                    lbSuppliers.Items.Add("Phone: " + reader["Phone"]);
                }
                else
                    lbSuppliers.Items.Add("NO RECORD FOUND");
                
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection ERROR..... :( " + er.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            try
            {
                if(ddlSuppliers.SelectedIndex != 0)
                {
                    string sqlQuery = "Select * from Suppliers where SupplierID =" + ddlSuppliers.SelectedValue;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dvSupplier.DataSource = reader;
                    dvSupplier.DataBind();
                }
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection ERROR..... :( " + er.Message;
            }
            finally
            {
                con.Close();
                //lblConnection.Text += "  .. Now the connection is closed..";
            }
        }
    }
}
/*
SqlConnection con = new SqlConnection(ConString);
            try
            {
                con.Open();
                lblConnection.Text = "Connection establishes..... :)";
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection ERROR..... :(";
            }
            finally
            {
                con.Close();
                lblConnection.Text += "  .. Now the connection is closed..";
            }
            */