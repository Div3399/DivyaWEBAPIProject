using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeltecWeb.Model
{
    public class Employee
    {
      
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Bank { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Blodgroup { get; set; }

    }


    public class ChckEmployees
    {
        public List<Employee> Data { get; set; }

        public bool status { get; set; }

        public string message { get; set; }


    }

    public class CheckAddEmp
    {
        public string EmployeeId { get; set; }

        public bool status { get; set; }

        public string message { get; set; }
    }

}