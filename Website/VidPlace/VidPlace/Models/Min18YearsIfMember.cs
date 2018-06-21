using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Min18YearsIfMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
           
            //if customer chooses pay as you go the age is not required =>
            // no validation error
            if (customer.MembershipID ==Membership.Unknown|| 
                customer.MembershipID ==Membership.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            //Customer choose other plans
            if(customer.BirthDate == null)
            {
                return new ValidationResult("The birthdate is required for a payed plan");
            }
            //Calculate the age
            var age = DateTime.Now.Year - customer.BirthDate.Value.Year;
            return (age >= 18) ? ValidationResult.Success :
                new ValidationResult("Customer has to be 18 years old");
        }
    }
}