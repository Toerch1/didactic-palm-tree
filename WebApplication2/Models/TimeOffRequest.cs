using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TimeOffRequest
    {
        [Key]
        public int ID
        {
            get; set;
        }

        public int EmpId
        {
            get; set;
        }

        public DateTime RequestDate
        {
            get; set;
        }

        public DateTime StartDate
        {
            get; set;
        }

        public DateTime EndDate
        {
            get; set;
        }

        public char Status
        {
            get; set;
        }

        public int Reviewer
        {
            get; set;
        }
    }
}