using MicrobrewitAspNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrobrewitAspNet5.Repository
{
    public interface IGlassRepository
    {
        IEnumerable<Glass> GetAll();
        Glass GetSingle(int id);
        void Add(Glass glass);
    }
}
