using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class VideoRentalStoreRepository
    {
        VideoRentalStoreDBContext context = new VideoRentalStoreDBContext();
        //get all customers
        public List<Customer> GetAllCustomers()
        {
            return (from e in context.Customers select e).ToList();
        }

        //get the customer by it's id
        public Customer GetCustomerbyID(int ID)
        {
            return (from e in context.Customers where e.ID == ID select e).SingleOrDefault();
        }

        //add new cutomer ======== to be done!!!!
        public void AddNewCustomer(Customer c)
        {
            context.Customers.Add(c); 
            context.SaveChanges();
        }

        
      
        //update the selected customer
        public void UpdateCustomer(Customer originalCustomer, Customer customer)
        {
            Customer c = GetCustomerbyID(originalCustomer.ID);
            c.FirstName = customer.FirstName;
            c.LastName = customer.LastName;
            c.Address = customer.Address;
            c.PhoneNumber = customer.PhoneNumber;
            c.ListOfRentalRecords = customer.ListOfRentalRecords;
            context.SaveChanges();
        }


        //get medias by the searched titles
        public List<string> GetMediasByTitle(string Title)
        {
            return (from e in context.Medias
                        //where e.ID == emplID
                    select e.Title).ToList();
        }

        // adding media by id ==== to be done!!
        public void AddNewMedia(int ID)
        {

        }
        //add a new rental recored ===== to be done!!!!
        public void AddRentalRecord(int ID)
        {
            // RentalRecord rr = null;
        }

    }
}