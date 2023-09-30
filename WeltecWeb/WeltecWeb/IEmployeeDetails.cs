using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WeltecWeb.Model;

namespace WeltecWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeDetails" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeDetails
    {
        [OperationContract]
        void DoWork();

        #region Employee
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetEmployees", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        ChckEmployees GetEmployees();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetEmployeeByid/{EmployeeId}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        ChckEmployees GetEmployeeByid(string EmployeeId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AddEmployee", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]

        CheckAddEmp AddEmployee(string FirstName, string LastName, string Gender, string Age, string HomeAddress, string MobileNo, string Qualification, string PassOutYear, string College, string Grade, string Experience
            , string Designation, string BankName, string Branch, string AccountType, string BankAccountNo);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "EditEmployee/{EmployeeId}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]

        CheckAddEmp EditEmployee(string EmployeeId, string FirstName, string MiddleName, string LastName);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteEmployee/{EmployeeId}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]

        CheckAddEmp DeleteEmployee(string EmployeeId);

        #endregion
    }
}
