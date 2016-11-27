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

        public virtual IDbSet<Responsable> Responsables { get; set; }

        public virtual IDbSet<Naufrago> Naufragos { get; set; }

        public virtual IDbSet<Medicamento> Medicamentos { get; set; }

        public virtual IDbSet<Baja> Bajas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
