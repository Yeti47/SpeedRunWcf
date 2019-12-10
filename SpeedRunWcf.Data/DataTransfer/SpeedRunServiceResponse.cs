using SpeedRunWcf.Data.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SpeedRunWcf.Data.DataTransfer {

    [DataContract]
    public class SpeedRunServiceResponse {

        [DataMember]
        public bool IsError { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public SpeedRun[] SpeedRuns { get; set; }

    }

}
