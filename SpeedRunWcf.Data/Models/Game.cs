using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRunWcf.Data.Models {
    
    public class Game {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string Publisher { get; set; }

        public override string ToString() => $"{nameof(Id)}: {Id} | {nameof(Name)}: {Name}";

    }
}
