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
    public partial class Add_Shipper : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString_ADO"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string query =
                        "INSERT INTO Shippers VALUES ('" +
                        txtName.Text + "','" +
                        txtPhone.Text + "')";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Shipper added succesfully";
                    Response.Redirect("~/AllShippers.aspx");
                }
                catch (Exception er)
                {
                    lblResult.Text = er.Message;
                }
            }
        }
    }
}