using MicrobrewitAspNet5.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Threading.Tasks;
using System.Data.Common;

namespace MicrobrewitAspNet5.Repository
{

    public class GlassRepository : IGlassRepository
    {
        public void Add(Glass glass)
        {
            using (var context = new MbContext())
            {
                var glassId = context.Glasses.Max(g => g.GlassId) + 1;
                context.Glasses.Add(glass);
            }
        }
        public IEnumerable<Glass> GetAll()
        {
            using (var context = new MbContext())
            {
                return context.Glasses;
            }
        }

        public Glass GetSingle(int id)
        {
            using (var context = new MbContext())
            {
                return context.Glasses.SingleOrDefault(g => g.GlassId == id);
            }
        }
    }
}
