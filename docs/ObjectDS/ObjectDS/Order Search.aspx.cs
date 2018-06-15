using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObjectDS.Data;

namespace ObjectDS
{
    public partial class Order_Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*int orderID = 10250;
            using (var conext = new NorthwindDataContext())
            {
                var products = (from od in conext.Order_Details
                                join p in conext.Products
                                on od.ProductID equals p.ProductID
                                where od.OrderID == orderID
                                select new { od.ProductID, p.ProductName, od.Quantity, od.Discount, od.UnitPrice }).ToList();

                Label1.Text = products.GetType().ToString();
                //return products;
            }*/
        }
    }
}