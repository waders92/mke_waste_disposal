using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MKEWasteDisposal.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PickUpDate { get; set; }
        public string UserID { get; set; }



        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }




        [ForeignKey("Bill")]
        public int BillId { get; set; }
        public Bill Bill { get; set; }

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }



        public List<Customer> Customers { get; set; }
        public ApplicationUser User { get; set; }
    }
}