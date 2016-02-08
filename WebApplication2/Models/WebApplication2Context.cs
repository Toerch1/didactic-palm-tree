using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class WebApplication2Context : DbContext
    {
        public virtual DbSet<Employee> Employees
        {
            get; set;
        }

        public virtual DbSet<DayCode> DayCodes
        {
            get; set;
        }

        public virtual DbSet<EmpSched> EmpScheds
        {
            get; set;
        }

        public virtual DbSet<SchedDays> SchedDayss
        {
            get; set;
        }

        public virtual DbSet<Schedule> Schedules
        {
            get; set;
        }

        public virtual DbSet<TimeOffRequest> TimeOffRequests
        {
            get; set;
        }

        public virtual DbSet<WorkTime> WorkTimes
        {
            get; set;
        }
    }
}