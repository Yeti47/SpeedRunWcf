using Microsoft.EntityFrameworkCore;
using SpeedRunWcf.Data.Models;
using SpeedRunWcf.Data.Repositories;
using SpeedRunWcf.Infrastructure.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedRunWcf.Infrastructure.Repositories {

    public class SpeedRunRepository : ISpeedRunRepository {

        private readonly SpeedRunDatabaseContext _context;

        public SpeedRunRepository(SpeedRunDatabaseContext context) {

            _context = context;

        }
        public SpeedRun GetItem(int id) {

            return _context.Set<SpeedRun>()
                .Include(x => x.Player)
                .Include(x => x.Game)
                .FirstOrDefault(x => x.Id == id);

        }

        public IEnumerable<SpeedRun> GetItems() {

            return _context.Set<SpeedRun>()
                .Include(x => x.Game)
                .Include(x => x.Player)
                .ToList();

        }
    }

}
