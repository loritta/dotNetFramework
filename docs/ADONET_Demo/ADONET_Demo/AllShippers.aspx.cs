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
    public partial class AllShippers : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString_ADO"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConString);
                try
                {
                    string sqlQuery = "Select * from Shippers";
                    SqlCommand cmd = new SqlCommand(sqlQuery,con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    gvShippers.DataSource = reader;
                    gvShippers.DataBind();

                }
                catch (Exception er)
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}