using SpeedRunWcf.Data.Models;
using SpeedRunWcf.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SpeedRunWcf.Infrastructure.Config;
using System.Linq;

namespace SpeedRunWcf.Infrastructure.Repositories {

    public class GameRepository : IGameRepository {

        private readonly SpeedRunDatabaseContext _context;

        public GameRepository(SpeedRunDatabaseContext context) {

            _context = context;

        }

        public Game GetItem(int id) => _context.Set<Game>().Find(id);

        public IEnumerable<Game> GetItems() {

            return _context.Set<Game>().ToList();

        }
    }

}
