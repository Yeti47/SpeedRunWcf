using System;
using System.Collections.Generic;
using System.Text;
using SpeedRunWcf.Data.Models;

namespace SpeedRunWcf.Data.Repositories {
    public interface IPlayerRepository {

        Player GetItem(int id);

        IEnumerable<Player> GetItems();

    }

}
