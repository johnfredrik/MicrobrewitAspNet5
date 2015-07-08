using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrobrewitAspNet5.Models
{
    public class Origin
    {
        public int OriginId { get; set; }
        public string Name { get; set; }
        public ICollection<Hop> Hops { get; set; }

    }
}
