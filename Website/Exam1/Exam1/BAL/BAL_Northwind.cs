using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam1.Data;


namespace Exam1.BAL
{
    public class BAL_Northwind
    {
        /*
         * Methode to get cities from the Suppliers table
         * */
        public List<string> getSupplierCity()
        {
            using (var context = new NorthwindDataContext())
            {
                List<string> citiesList = (from data in context.Suppliers
                                           select data.City).Distinct().ToList();
                return citiesList;
            }
        }

        /*
         * 
         * Method: will get all supplier names 
         * */

        public List<Supplier> getSupplierName()
        {
            using (var context = new NorthwindDataContext())
            {
                List<Supplier> nameList = (from data in context.Suppliers
                                           select data).ToList();
                return nameList;
            }

        }
        /*
        * 
        * Method: will get all supplier that are in the city selected in the previous control 
        * */
        public List<Supplier> getSupplierByCity(string city)
        {
            using (var context = new NorthwindDataContext())
            {
                List<Supplier> supplierList = (from data in context.Suppliers where data.City==city
                                           select data).ToList();
                return supplierList;
            }

        }
        /*
       * 
       * Method: will get all categories of products 
       * */
        public List<string> getProductCategories()
        {
            using (var context = new NorthwindDataContext())
            {
                List<string> categList = (from data in context.Categories
                                               select data.CategoryName).Distinct().ToList();
                return categList;
            }

        }

    }
}