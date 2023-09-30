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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClinicData" in both code and config file together.
    [ServiceContract]
    public interface IClinicData
    {
        [OperationContract]
        void DoWork();

        #region Clinic

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetClinic", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        checkclinicdata GetClinic();

        #endregion

    }
}
