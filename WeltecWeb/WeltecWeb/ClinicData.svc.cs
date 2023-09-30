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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClinicData" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClinicData.svc or ClinicData.svc.cs at the Solution Explorer and start debugging.
    public class ClinicData : IClinicData
    {
        General objG = new General();
        public void DoWork()
        {

        }

        #region Clinic
        public checkclinicdata GetClinic()
        {
            checkclinicdata objcheckclinic = new checkclinicdata();

            try
            {
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();

                nv.Add("@patientid", "0");

                dt = objG.GetDataTable("Sp_GetClinic", nv);

                if(dt!=null)
                {
                    var listclinic = new List<Clinic>();

                    for(int i =0; i<dt.Rows.Count; i++)
                    {
                        Clinic objclinic = new Clinic();

                        objclinic.PatientCode = dt.Rows[i]["PatientCode"].ToString();
                        objclinic.RegistrationDate = Convert.ToDateTime(dt.Rows[i]["RegistrationDate"]);
                        objclinic.PatientName = dt.Rows[i]["PatientName"].ToString() ;
                        objclinic.Gender = dt.Rows[i]["Gender"].ToString();
                        objclinic.Age = dt.Rows[i]["Age"].ToString();
                        objclinic.Address = dt.Rows[i]["Address"].ToString();
                        objclinic.TotalCost = Convert.ToDecimal(dt.Rows[i]["TotalCost"]);
                        objclinic.GrandTotal = Convert.ToDecimal(dt.Rows[i]["GrandTotal"]);
                        objclinic.PayDate = Convert.ToDateTime(dt.Rows[i]["PayDate"]);
                        objclinic.PaidAmount = Convert.ToDecimal(dt.Rows[i]["PaidAmount"]);
                        objclinic.PendingAmount = Convert.ToDecimal(dt.Rows[i]["PendingAmount"]);
                        objclinic.ClinicName = dt.Rows[i]["ClinicName"].ToString();
                        objclinic.ClinicTime = dt.Rows[i]["ClinicTime"].ToString();
                        objclinic.DoctorName = dt.Rows[i]["DoctorName"].ToString();

                        listclinic.Add(objclinic);
                    }

                    objcheckclinic.Data = listclinic;
                    objcheckclinic.status = true;
                    objcheckclinic.message = "Success";
                }
                else
                {
                    objcheckclinic.Data = null;
                    objcheckclinic.status = false;
                    objcheckclinic.message = "Failure";
                }
            }
            catch (Exception ex) 
            {
                objcheckclinic.Data= null;
                objcheckclinic.status = false;
                objcheckclinic.message= ex.Message;
            }

            return objcheckclinic;
        }
        #endregion

    }
}
