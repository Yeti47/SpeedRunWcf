using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRunWcf.Data.Models {
    public class SpeedRun {

        public int Id { get; set; }

        public DateTime RecordDate { get; set; }

        public TimeSpan Time { get; set; }

        public Player Player { get; set; }

        public Game Game { get; set; }

    }
}
