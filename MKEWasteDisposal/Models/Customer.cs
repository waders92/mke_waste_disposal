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
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Pick Up Day")]
        public string PickUpDate { get; set; }
        public string UserID { get; set; }
        [Display(Name = "Stop Pickup")]
        public string BlackOutStart { get; set; }
        [Display(Name = "End Pickup")]

        public string BlackOutEnd { get; set; }
        [Display(Name = "Bill Current?")]

        public bool hasPaid { get; set; }



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