using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;
using WeltecDemo.Model;

namespace WeltecDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMywebService" in both code and config file together.
    [ServiceContract]
    public interface IMywebService
    {
        [OperationContract]
        void DoWork();

        #region Coutry List
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetState/{CountryId}/{search}",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest)]

        CheckState GetState(string CountryId, string search);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AddEmployee",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest)]

        CheckEmpdetails AddEmployee(string FirstName, string LastName, string Gender, string Age,string HomeAddress,string BankName,string Branch);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateEmployee/{EmployeeId}",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest)]

        CheckEmpdetails UpdateEmployee(string FirstName, string LastName,string EmployeeId);
        #endregion

       


    }
}

