using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicrobrewitAspNet5.Models
{
    public class Glass
    {
        public int GlassId { get; set; }
        public string Name { get; set; }
    }
}
