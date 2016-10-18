using Depcom.TaberIsla.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Context
{
    public class DbTaberIslaContext : DbContext
    {
        public DbTaberIslaContext() : base("DBTaberIsla")
        {
            //Database.SetInitializer(new DbTaberIslaDataInitializer());
        }

        public virtual DbSet<Responsable> Responsables { get; set; }

        public virtual DbSet<Naufrago> Naufragos { get; set; }

        public virtual DbSet<Medicamento> Medicamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
