using SpeedRunWcf.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRunWcf.Data.Repositories {

    public interface ISpeedRunRepository {

        SpeedRun GetItem(int id);

        IEnumerable<SpeedRun> GetItems();

    }

}
