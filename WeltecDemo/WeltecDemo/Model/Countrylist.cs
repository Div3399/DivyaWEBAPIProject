using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;

namespace WeltecDemo.Model
{
 
    public class StateList
    {
        public int StateId { get; set; }
        public string StateName { get; set; }




    }

    public class CheckState
    {
        public List<StateList> Data { get; set; }

        public bool status { get; set; }

        public string message { get; set; }


    }

    public class CheckEmpdetails
    {

        public string EmployeeId { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }





}
