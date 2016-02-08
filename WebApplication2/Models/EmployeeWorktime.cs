using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EmployeeWorktime
    {
        private WebApplication2Context db = new WebApplication2Context();

        private List<Employee> mEmployees;
        private List<WorkTime> mWorkTimes;

        public EmployeeWorktime()
        {
            mEmployees = db.Employees.ToList();
            mWorkTimes = db.WorkTimes.ToList();
        }
    }
}