using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Schedule
    {
        [Key]
        public int ID
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public Boolean AdHoc
        {
            get; set;
        }

        public int StartTime
        {
            get; set;
        }

        public int EndTime
        {
            get; set;
        }

    }
}