using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeltecWeb.Model
{
    public class CountryList
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

    }

    public class cchkcountrylist
    {
        public List<CountryList> Data{ get; set; }

        public bool status { get; set; }

        public string message { get; set; }
    }
}