using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class WorkTime
    {
        [Key]
        [Column(Order = 0)]
        public int EmpID
        {
            get; set;
        }

        [Key]
        [Column(Order = 1)]
        public DateTime ActionTime
        {
            get; set;
        }

        [Key]
        [Column(Order = 2)]
        public char ActionType
        {
            get; set;
        }
    }
}