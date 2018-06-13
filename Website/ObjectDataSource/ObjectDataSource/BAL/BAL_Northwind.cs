using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObjectDataSource.Data;

namespace ObjectDataSource.BAL
{
    public class BAL_Northwind
    {
        /*
         * Methode to get countries from the Customers table
         * */
         public List<string> getCountries()
        {
            using (var context = new DatabaseDataContext())
            {
                List<string> contriesList = (from data in context.Customers
                                         select data.Country).Distinct().ToList();
                return contriesList;
            }
        }

        /*
         * Upon selection of a country all customers of that country will be displayed 
         * in the data grid,
         * 
         * Method: will get all customers from a specific country
         * */

        public List<Customer> getCustomersByCountry(string country)
        {
            using (var context = new DatabaseDataContext())
            {
                List<Customer> customersList = (from data in context.Customers
                                                where data.Country == country
                                             select data).ToList();
                return customersList;
            }

        }
        /*
        * Upon selection of a customer the details of that customer will be displayed in a
        * detailed view,
        * 
        * Method: will get customer details for a specific customer
        * */

        public Customer getCustomer(string customerID)
        {
            using (var context = new DatabaseDataContext())
            {
                Customer customer = (from data in context.Customers
                                                where data.CustomerID == customerID
                                                select data).SingleOrDefault();
                return customer;
            }

        }

        /*
        * Upon selection of a date the details of that order will be displayed in a
        * grid view,
        * 
        * Method: will get orders list for a specific date
        * */
        public List<Order> getOrdersbyDate(DateTime date)
        {
            using (var context = new DatabaseDataContext())
            {
                List <Order> orders = (from data in context.Orders
                                     where data.OrderDate == date
                                     orderby data.OrderID select data).ToList();
                return orders;
            }
        }

        /*
        * Upon selection of an order the products of that order will be displayed in a
        * grid view,
        * 
        * Method: will get product list for a specific order
        * */
        public List<Product> getProductsbyOrder(int orderID)
        {
            using (var context = new DatabaseDataContext())
            {
                List<Product> products = (from data in context.Order_Details
                                          join product in context.Products 
                                          on data.ProductID equals product.ProductID
                                      where data.OrderID == orderID
                                      select product).ToList();
                return products;
            }
        }
        /*
        public object getProductsbyOrderWithDetails(int orderID)
        {
            using (var context = new DatabaseDataContext())
            {
                var products = (from data in context.Order_Details
                                          join product in context.Products
                                          on data.ProductID equals product.ProductID
                                          where data.OrderID == orderID
                                          select new { data.ProductID, product.ProductName, data.Quantity, data.Discount, data.UnitPrice }).ToList();
               
                return products;
            }
        }*/

    }
}