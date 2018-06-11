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
    public partial class AddShipper : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings
           ["NORTHWNDConnectionString_ADO"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(ConString)){
                try
                {
                    string sqlQuery = "Insert into Shippers values('"
                        + tbName.Text + "','" +
                        tbPhone.Text + "')";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
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