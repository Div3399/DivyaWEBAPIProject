using CustomizesWebApp.MyClass;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WeltecWeb.Model;

namespace WeltecWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyWebService.svc or MyWebService.svc.cs at the Solution Explorer and start debugging.
    public class MyWebService : IMyWebService
    {
        General objGn = new General();
        public void DoWork()
        {

        }

        #region CoutryList
        public cchkcountrylist GetCountryList(string CountryId)
        {
            cchkcountrylist ObjCheck = new cchkcountrylist();

            try
            {

                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();

                nv.Add("@CountryId", CountryId);
               
                dt = objGn.GetDataTable("SP_GetCountry", nv);

                if (dt != null)
                {
                    var lstCountry = new List<CountryList>();


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        CountryList objC = new CountryList();

                        objC.CountryName = dt.Rows[i]["CountryName"].ToString();
                        lstCountry.Add(objC);
                    }

                    ObjCheck.Data = lstCountry;
                    ObjCheck.status = true;
                    ObjCheck.message = "Success";
                }
                else
                {
                    ObjCheck.Data = null;
                    ObjCheck.status = false;
                    ObjCheck.message = "Failure";
                }

            }
            catch (Exception ex)
            {

                ObjCheck.Data = null;
                ObjCheck.status = false;
                ObjCheck.message = ex.Message;


            }

            return ObjCheck;
        }
        #endregion
    }
}
