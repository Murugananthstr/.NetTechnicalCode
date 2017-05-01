using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC1.Models
{
    public class Employee
    {

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string DepName { get; set; }
        public Employee()
        {

        }

        public Employee(int empid, string empName, string depname)
        {
            this.DepName = depname;
            this.EmpName = empName;
            this.EmpId = empid;
        }
    }
}