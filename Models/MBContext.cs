using MicrobrewitAspNet5;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrobrewitAspNet5.Models
{
    public class MbContext : DbContext
    {
        public DbSet<Glass> Glasses { get; set; }
        public DbSet<Hop> Hops { get; set; }
        public DbSet<Origin> Origin { get; set; }
        public DbSet<HopForm> HopForms { get; set; }

        protected override void OnConfiguring(EntityOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=C:\temp\mb.db");
            //var con = Startup.Configuration.Get("Data:SQLite:Connectionstring");
            //options.UseSqlite(Startup.Configuration.Get("Data:SQLite:Connectionstring"));


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Glass>().Key(g => g.GlassId);
            builder.Entity<Glass>().Table("Glasses");

          

            builder.Entity<Origin>().Key(o => o.OriginId);
            builder.Entity<Origin>().Table("Origins");

            builder.Entity<Hop>().Key(h => h.HopId);
            builder.Entity<Hop>().Table("Hops");

            builder.Entity<HopForm>().Key(hf => hf.Id);
            builder.Entity<HopForm>().Table("HopForms");

            base.OnModelCreating(builder);
        }
    }
}
