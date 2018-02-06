using MKEWasteDisposal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MKEWasteDisposal.Data
{
    public class SeedData
    {
        List<Customer> customers = new List<Customer>()
                {
                new Customer()
                {
                    FirstName = "Mike",
                    LastName = "Vachoy",
                    PhoneNumber = "414-731-3938",
                    PickUpDate = "Monday",
                },
                new Customer()
                {
                    FirstName = "Tony",
                    LastName = "Maleki",
                    PhoneNumber = "414-731-3545",
                    PickUpDate = "Monday",
                },
                new Customer()
                {
                    FirstName = "Vic",
                    LastName = "Stiegle",
                    PhoneNumber = "414-234-3935",
                    PickUpDate = "Tuesday",
                },
                new Customer()
                {
                    FirstName = "Robert",
                    LastName = "Mader",
                    PhoneNumber = "414-743-3487",
                    PickUpDate = "Thursday",
                },
                new Customer()
                {
                    FirstName = "Julie",
                    LastName = "Meechum",
                    PhoneNumber = "414-751-1111",
                    PickUpDate = "Friday",
                },
             };
    }
}