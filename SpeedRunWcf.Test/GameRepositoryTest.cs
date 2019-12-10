using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedRunWcf.Data.Models;
using SpeedRunWcf.Infrastructure.Repositories;
using SpeedRunWcf.Infrastructure.Config;

namespace SpeedRunWcf.Test {

    [TestClass]
    public class GameRepositoryTest {

        [TestMethod]
        public void GetGame() {

            const int targetId = 101;

            using (SpeedRunDatabaseContext context = new SpeedRunDatabaseContext()) {

                GameRepository gameRepository = new GameRepository(context);

                Game superMetroid = gameRepository.GetItem(targetId);

                Assert.IsTrue(superMetroid != null && superMetroid.Name.Contains("Metroid"));

            }

        }

        [TestMethod]
        public void GetGames() {

            using (SpeedRunDatabaseContext context = new SpeedRunDatabaseContext()) {

                GameRepository gameRepository = new GameRepository(context);

                IEnumerable<Game> games = gameRepository.GetItems();

                Assert.IsTrue(games != null && games.Any());

            }

        }

    }

}
