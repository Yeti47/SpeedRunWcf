using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedRunWcf.Data.Models;
using SpeedRunWcf.Infrastructure.Config;
using SpeedRunWcf.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRunWcf.Test {

    [TestClass]
    public class SpeedRunRepositoryTest {

        [TestMethod]
        public void GetSpeedRuns() {

            using(SpeedRunDatabaseContext context = new SpeedRunDatabaseContext()) {

                SpeedRunRepository repo = new SpeedRunRepository(context);

                IEnumerable<SpeedRun> speedRuns = repo.GetItems();

                Assert.IsTrue(speedRuns != null && speedRuns.Any());

            }

        }

    }

}
