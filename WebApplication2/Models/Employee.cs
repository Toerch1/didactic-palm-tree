using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Key]
        public int ID
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public char MI
        {
            get; set;
        }

        public int Supervisor
        {
            get; set;
        }

        public Boolean Active
        {
            get; set;
        }

        public char Level
        {
            get; set;
        }

        public DateTime HireDate
        {
            get; set;
        }

        public DateTime TermDate
        {
            get; set;
        }
    }
}