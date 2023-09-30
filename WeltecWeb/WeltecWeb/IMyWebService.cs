using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;
using WeltecWeb.Model;

namespace WeltecWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyWebService" in both code and config file together.
    [ServiceContract]
    public interface IMyWebService
    {
        [OperationContract]
        void DoWork();

        #region Coutry List
        [OperationContract]
         [WebInvoke(Method = "GET", UriTemplate = "GetCountryList/{CountryId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        cchkcountrylist GetCountryList(string CountryId);
        #endregion
    }
}
