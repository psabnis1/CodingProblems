using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SampleWCFService
{
    [ServiceContract]
    public interface IVehicle
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Vehicle", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        Vehicle Get(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Vehicle")]

        Stream Update(Vehicle record);
        
        
    }
}
