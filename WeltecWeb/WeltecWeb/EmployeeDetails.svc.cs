using CustomizesWebApp.MyClass;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WeltecWeb.Model;


namespace WeltecWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeDetails" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeDetails.svc or EmployeeDetails.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeDetails : IEmployeeDetails
    {
        General objGe = new General();
        public void DoWork()
        {

        }

        #region Employee
        public ChckEmployees GetEmployees()
        {
            ChckEmployees ObjCheckEmp = new ChckEmployees();
            try
            {

                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();

                nv.Add("@EmployeeId", "0");
                

                dt = objGe.GetDataTable("Get_EmpDetails", nv);

                if (dt != null)
                {
                    var lstemp = new List<Employee>();


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Employee objEmp = new Employee();

                        objEmp.EmployeeName = dt.Rows[i]["EmployeeName"].ToString();
                        objEmp.Address = dt.Rows[i]["Address"].ToString();
                        objEmp.Education = dt.Rows[i]["Education"].ToString();
                        objEmp.Experience = dt.Rows[i]["Experience"].ToString();
                        objEmp.Blodgroup = dt.Rows[i]["Blodgroup"].ToString();
                        objEmp.Bank = dt.Rows[i]["Bank"].ToString();


                        lstemp.Add(objEmp);
                    }

                    ObjCheckEmp.Data = lstemp;
                    ObjCheckEmp.status = true;
                    ObjCheckEmp.message = "Success";
                }
                else
                {
                    ObjCheckEmp.Data = null;
                    ObjCheckEmp.status = false;
                    ObjCheckEmp.message = "Failure";
                }

            }
            catch (Exception ex)
            {

                ObjCheckEmp.Data = null;
                ObjCheckEmp.status = false;
                ObjCheckEmp.message = ex.Message;


            }

            return ObjCheckEmp;
        }

        public ChckEmployees GetEmployeeByid (string EmployeeId)
        {
            ChckEmployees objCheck = new ChckEmployees();

            try
            {
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@EmployeeId", EmployeeId);
                
                dt = objGe.GetDataTable("Get_EmpId", nv);

                if(dt!=null)
                {
                    var EmpID = new List<Employee>();

                    for(int i=0 ; i<dt.Rows.Count; i++)
                    {
                        Employee objEmp = new Employee();

                        objEmp.EmployeeId = Convert.ToInt32(dt.Rows[i]["EmployeeId"]);
                        objEmp.EmployeeName = dt.Rows[i]["EmployeeName"].ToString();
                        objEmp.Address = dt.Rows[i]["Address"].ToString();
                        objEmp.Education = dt.Rows[i]["Education"].ToString();
                        objEmp.Experience = dt.Rows[i]["Experience"].ToString();
                        objEmp.Blodgroup = dt.Rows[i]["Blodgroup"].ToString();
                        objEmp.Bank = dt.Rows[i]["Bank"].ToString();



                        EmpID.Add(objEmp);

                    }
                    objCheck.Data = EmpID;
                    objCheck.status = true;
                    objCheck.message = "Success";
                }
                else
                {
                    objCheck.Data = null;
                    objCheck.status = false;
                    objCheck.message = "Failure";
                }
            }
            catch(Exception ex) 
            {
                objCheck.Data = null;
                objCheck.status = false;
                objCheck.message = ex.Message;
            
            
            }
            return objCheck;
        }

        public CheckAddEmp AddEmployee(string FirstName,string LastName,string Gender,string Age,string HomeAddress,string MobileNo,string Qualification,string PassOutYear,string College,string Grade,string Experience
            ,string Designation,string BankName,string Branch,string AccountType,string BankAccountNo)
        {
            CheckAddEmp objCheckAdd = new CheckAddEmp();

            try
            {
                int Isresult =0;
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@EmployeeId", "0");
                nv.Add("@FirstName", FirstName);
                nv.Add("@LastName", LastName);
                nv.Add("@Gender", Gender);
                nv.Add("@Age", Age);
                nv.Add("@HomeAddress", HomeAddress);
                nv.Add("@MobileNo", MobileNo);
                nv.Add("@Qualification", Qualification);
                nv.Add("@PassOutYear", PassOutYear);
                nv.Add("@College", College);
                nv.Add("@Grade", Grade);
                nv.Add("@Experience", Experience);
                nv.Add("@Designation", Designation);
                nv.Add("@BankName", BankName);
                nv.Add("@Branch", Branch);
                nv.Add("@AccountType", AccountType);
                nv.Add("@BankAccountNo", BankAccountNo);


                Isresult = objGe.GetDataExecuteScaler("Sp_SetAddEmp", nv);

                if (Isresult>0)
                {
                    objCheckAdd.EmployeeId=Isresult.ToString();
                    objCheckAdd.status = true;
                    objCheckAdd.message="Success";

                }
                else
                {
                   objCheckAdd.EmployeeId="0";
                   objCheckAdd.status=false;
                   objCheckAdd.message="Failure";
                }

            }
            catch (Exception ex) 
            { 
                objCheckAdd.EmployeeId ="0";
                objCheckAdd.status = false;
                objCheckAdd.message= ex.Message;
              
            
            }
            return objCheckAdd;


        }

        public CheckAddEmp EditEmployee( string EmployeeId,string FirstName,string MiddleName,string LastName)
        {
            CheckAddEmp objCheckAdd = new CheckAddEmp();

            try
            {
                int Isresult = 0;
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@EmployeeId", EmployeeId);
                nv.Add("@FirstName", FirstName);
                nv.Add("@MiddleName", MiddleName);
                nv.Add("@LastName", LastName);

                Isresult = objGe.GetDataExecuteScaler("Set_EditEmpDetails", nv);

                if(Isresult>0)
                {
                    objCheckAdd.EmployeeId = Isresult.ToString();
                    objCheckAdd.status=true;
                    objCheckAdd.message = "Success";
                }
                else 
                {
                    objCheckAdd.EmployeeId = "0";
                    objCheckAdd.status=false;
                    objCheckAdd.message = "Failure";
                
                }

            }
            catch(Exception ex)
            {
                objCheckAdd.EmployeeId = "0";
                objCheckAdd.status = false;
                objCheckAdd.message= ex.Message;
            }
            return objCheckAdd;

        }

        public CheckAddEmp DeleteEmployee(string EmployeeId) 
        {
            CheckAddEmp objCheckAdd = new CheckAddEmp();
            try
            {
                int Isreult = 0;
                DataTable dt = new DataTable();
                NameValueCollection nv = new NameValueCollection();
                nv.Add("@EmployeeId", EmployeeId);

                Isreult = objGe.GetDataExecuteScaler("Set_DeleteEmpDetails", nv);

                if(Isreult>0) 
                {
                    objCheckAdd.EmployeeId = Isreult.ToString();
                    objCheckAdd.status=true;
                    objCheckAdd.message = "Success";
                
                }
                else
                {
                    objCheckAdd.EmployeeId = "0";
                    objCheckAdd.status=false;
                    objCheckAdd.message = "Failure";
                }
            }
            catch (Exception ex)
            {
                objCheckAdd.EmployeeId="0";
                objCheckAdd.status= false;
                objCheckAdd.message=ex.Message;
            }
            return objCheckAdd;
        
        }
        
        #endregion

    }

}