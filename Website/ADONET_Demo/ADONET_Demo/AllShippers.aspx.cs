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
    public partial class AllShippers : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings
           ["NORTHWNDConnectionString_ADO"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConString);

                try
                {
                    string sqlQuery = "select * from Shippers";
                    //lblConnection.Text = "Connection established... :)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    gvShippers.DataSource = reader;
                    gvShippers.DataBind();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    con.Close();
                    //lblConnection.Text += "...Now the connection is closed..";
                }
            }
        }
    }
}