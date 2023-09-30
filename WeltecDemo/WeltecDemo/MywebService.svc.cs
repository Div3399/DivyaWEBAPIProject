using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI;
using WeltecDemo.Model;
using WeltecDemo.MyClass;

namespace WeltecDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MywebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MywebService.svc or MywebService.svc.cs at the Solution Explorer and start debugging.
    public class MywebService : IMywebService
    {
        Weltectemployees2Entities db = new Weltectemployees2Entities();
        General objGn = new General();
        public void DoWork()
        {

        }

        #region Statelist

        public CheckState GetState(string CountryId, string search)
        {
            CheckState objchecks = new CheckState();

            try
            {
                db = new Weltectemployees2Entities();

                var id = int.Parse(CountryId);

                var state = (from S in db.StateMasters
                             orderby S.CountryId descending
                             where S.IsActive == true && S.CountryId == id && S.StateName == search
                             select S).ToList();

                StateList objState = new StateList();

                if (state != null)
                {
                    var lstState = new List<StateList>();

                    foreach (var item in state)
                    {
                        objState = new StateList();

                        objState.StateId = item.StateId;

                        objState.StateName = item.StateName;

                        lstState.Add(objState);
                    }
                    objchecks.Data = lstState;
                    objchecks.status = true;
                    objchecks.message = "Success";
                }
                else
                {
                    objchecks.Data = null;
                    objchecks.status = false;
                    objchecks.message = "Failure";
                }

            }
            catch (Exception ex)
            {
                objchecks.Data = null;
                objchecks.status = false;
                objchecks.message = ex.Message;


            }
            return objchecks;

        }

        public CheckEmpdetails AddEmployee(string FirstName, string LastName, string Gender, string Age, string HomeAddress, string BankName, string Branch)
        {
            CheckEmpdetails ObjCheck = new CheckEmpdetails();

            try
            {
                db = new Weltectemployees2Entities();
                int IsResult = 0;


                var Emp = new PersonalDetail
                {

                    FirstName = FirstName,
                    LastName = LastName,
                    Gender = Gender,
                    Age = Convert.ToInt32(Age)


                };
                db.PersonalDetails.Add(Emp);
                IsResult = db.SaveChanges();

                var EmpId = Emp.EmployeeId;
                var EmpC = new ContactDetail
                {
                    EmployeeId = EmpId,
                    HomeAddress = HomeAddress,

                };
                db.ContactDetails.Add(EmpC);
                IsResult = db.SaveChanges();


                var EmpB = new BankDetail
                {
                    EmployeeId = EmpId,
                    BankName = BankName,
                    Branch = Branch


                };
                db.BankDetails.Add(EmpB);
                IsResult = db.SaveChanges();


                if (IsResult > 0)
                {
                    ObjCheck.EmployeeId = IsResult.ToString();
                    ObjCheck.status = true;
                    ObjCheck.message = "Success";
                }
                else
                {
                    ObjCheck.EmployeeId = "0";
                    ObjCheck.status = false;
                    ObjCheck.message = "Failure";
                }

            }
            catch (Exception ex)
            {
                ObjCheck.EmployeeId = "0";
                ObjCheck.status = false;
                ObjCheck.message = ex.Message;


            }

            return ObjCheck;
        }

        public CheckEmpdetails UpdateEmployee(string FirstName, string LastName, string EmployeeId )
        {
            CheckEmpdetails ObjCheck = new CheckEmpdetails();

            try
            {
                db = new Weltectemployees2Entities();
                int IsResult = 0;

                var EmpId = int.Parse(EmployeeId);
                var res = (from PD in db.PersonalDetails
                           where PD.EmployeeId == EmpId
                           select PD
                           ).FirstOrDefault();

                //var ress = (from p in db.PersonalDetails
                //            where p.FirstName == FirstName
                //            select p).FirstOrDefault();
                //ress.LastName = EmployeeId;
                //if (ress != null)
                //{
                //    ress.FirstName = FirstName;
                //    ress.LastName = LastName;
                //}

                res.FirstName = FirstName;
                res.LastName = LastName;
                
                IsResult = db.SaveChanges();



                if (IsResult > 0)
                {
                    ObjCheck.EmployeeId = IsResult.ToString();
                    ObjCheck.status = true;
                    ObjCheck.message = "Success";
                }
                else
                {
                    ObjCheck.EmployeeId = "0";
                    ObjCheck.status = false;
                    ObjCheck.message = "Failure";
                }

            }
            catch (Exception ex)
            {
                ObjCheck.EmployeeId = "0";
                ObjCheck.status = false;
                ObjCheck.message = ex.Message;


            }

            return ObjCheck;

        }
        #endregion


    }
}

