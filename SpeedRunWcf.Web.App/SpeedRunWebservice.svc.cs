using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SpeedRunWcf.Data.DataTransfer;
using SpeedRunWcf.Data.Models;
using SpeedRunWcf.Infrastructure.Config;
using SpeedRunWcf.Infrastructure.Repositories;
using SpeedRunWcf.Service;

namespace SpeedRunWcf.Web.App {

    [ServiceBehavior]
    public class SpeedRunWebservice : ISpeedRunWebservice {

        public SpeedRunServiceResponse GetSpeedRuns(SpeedRunServiceRequest req) {

            try {

                using(SpeedRunDatabaseContext context = new SpeedRunDatabaseContext()) {

                    SpeedRunRepository speedRunRepository = new SpeedRunRepository(context);

                    SpeedRunService speedRunService = new SpeedRunService(speedRunRepository);

                    IEnumerable<SpeedRun> speedRuns = speedRunService.GetAllSpeedRuns();

                    SpeedRunServiceResponse response = new SpeedRunServiceResponse();
                    response.SpeedRuns = speedRuns.ToArray();

                    return response;

                }

            }
            catch(Exception exception) {

                SpeedRunServiceResponse response = new SpeedRunServiceResponse();
                response.IsError = true;
                response.Message = exception.Message;

                return response;

            }


        }

    }

}
