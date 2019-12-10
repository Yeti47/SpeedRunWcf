using SpeedRunWcf.Data.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SpeedRunWcf.Web.App {

    [ServiceContract]
    public interface ISpeedRunWebservice {


        [OperationContract]
        SpeedRunServiceResponse GetSpeedRuns(SpeedRunServiceRequest req);

    }

}
