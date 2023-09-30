using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeltecWeb.Model
{
    public class Clinic
    {
        public int patientid { get; set; }
        public string PatientCode { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PatientName { get; set; }
        public string Gender { get; set; }  
        public string Age { get; set;}
        public string Address { get; set; }
        public decimal TotalCost { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime PayDate { get; set; }
        public decimal PaidAmount { get; set; } 
        public decimal PendingAmount { get; set; }
        public string ClinicName { get; set; }
        public string ClinicTime { get; set; }
        public string DoctorName { get; set; }
        
    }

     public class checkclinicdata
     {
        public List<Clinic>Data { get; set; }

        public bool status { get; set; }

        public string message { get; set; }

     } 

}