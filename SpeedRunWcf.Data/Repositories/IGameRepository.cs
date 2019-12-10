using SpeedRunWcf.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRunWcf.Data.Repositories {
    
    public interface IGameRepository {

        Game GetItem(int id);

        IEnumerable<Game> GetItems();

    }

}
