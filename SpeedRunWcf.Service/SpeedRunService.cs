using SpeedRunWcf.Data.Models;
using SpeedRunWcf.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRunWcf.Service {
    
    public class SpeedRunService {

        #region Fields

        private readonly ISpeedRunRepository _speedRunRepository;

        #endregion

        #region Props

        #endregion

        #region Ctors

        public SpeedRunService(ISpeedRunRepository speedRunRepository) {

            _speedRunRepository = speedRunRepository;

        }

        #endregion

        #region Methods

        public IEnumerable<SpeedRun> GetAllSpeedRuns() => _speedRunRepository.GetItems();

        #endregion

    }

}
