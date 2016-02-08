using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DayCode
    {
        [Key]
        public int ID
        {
            get; set;
        }

        public string Day
        {
            get; set;
        }
    }
}