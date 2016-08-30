using Depcom.TaberIsla.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Context
{
    public class DbTaberIsla : DbContext
    {
        public DbTaberIsla() : base("DBTaberIsla")
        {
            //Database.SetInitializer(new DbTaberIslaDataInitializer());
        }

        public DbSet<Responsable> Responsables { get; set; }

        public DbSet<Naufrago> Naufragos { get; set; }

        public DbSet<Medicamento> Medicamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
