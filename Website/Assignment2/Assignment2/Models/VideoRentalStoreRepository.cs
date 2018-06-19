using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            try
            {
                context.Customers.Add(c);
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
      
        //update the selected customer
        public void UpdateCustomer(Customer originalCustomer, Customer customer, int ID, 
            string FirstName, string LastName, string Address,string PhoneNumber)
        {
            Customer c = GetCustomerbyID(ID);
            c.FirstName = FirstName;
            c.LastName = LastName;
            c.Address = Address;
            c.PhoneNumber = PhoneNumber;
            context.SaveChanges();
          
        }

        // adding media by its class!
        public void AddNewMedia(Media m)
        {
            try
            {
                context.Medias.Add(m);
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        //add a new rental recored -----> NOt working an dI'm tierd.. MAybe I'll find the fix tomorrow.
        public void AddRentalRecord(int customerID, List<int> mediaID)
        {            
            try
            {
                Customer c = GetCustomerbyID(customerID);
                RentalRecord rr=new RentalRecord();
                Media m = new Media();
                foreach (var item in mediaID)
                {
                    m = GetMediaByID(item);
                    
                    rr.ListOfRentedMedias.Add(m);
                }
                rr.RentalDate = DateTime.Now.Date;
                c.ListOfRentalRecords.Add(rr);
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        //search media by title
        public List<Media> getMediaTitle(string text)
        {
            return (from e in context.Medias where e.Title == text select e).ToList();
        }
        //search media by type
        public List<Media> getMediaType(string text)
        {
            return (from e in context.Medias where e.MType == text select e).ToList();
        }
        //search media by year
        public List<Media> getMediaYear(DateTime year)
        {
            return (from e in context.Medias where e.ProductionYear == year select e).ToList();
        }
        //search media by Id
        public Media GetMediaByID(int ID)
        {
            return (from e in context.Medias where e.ID == ID select e).SingleOrDefault();
        }
    }
}