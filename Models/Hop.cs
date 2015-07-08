using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrobrewitAspNet5.Models
{
    public class Hop
    {
        public int HopId { get; set; }
        public string Name { get; set; }
        public double AALow { get; set; }
        public double AAHigh { get; set; }
        public double BetaLow { get; set; }
        public double BetaHigh { get; set; }
        public string Notes { get; set; }
        public string FlavourDescription { get; set; }
        public bool Custom { get; set; }
        public int? OriginId { get; set; }
        public virtual Origin Origin { get; set; }
    }
}
