using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRunWcf.Data.Models {
    
    public class Player {

        public int Id { get; set; }

        public string GamerTag { get; set; }

        public override string ToString() => $"{nameof(Id)}: {Id} | {nameof(GamerTag)}: {GamerTag}";

    }
}
