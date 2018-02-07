using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MKEWasteDisposal.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }
        public string PickUpFrequency { get; set; }
    }
}