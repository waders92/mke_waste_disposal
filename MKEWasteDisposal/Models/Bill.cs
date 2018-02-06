using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MKEWasteDisposal.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        public float Amount { get; set; }
    }
}