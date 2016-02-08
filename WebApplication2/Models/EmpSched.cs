using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EmpSched
    {
        [Key]
        [Column(Order = 0)]
        public int EmpID
        {
            get; set;
        }

        [Key]
        [Column(Order = 1)]
        public int SchedID
        {
            get; set;
        }

        [Key]
        [Column(Order = 2)]
        public DateTime StartDate
        {
            get; set;
        }

        public DateTime EndDate
        {
            get; set;
        }
    }
}