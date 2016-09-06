using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Entity;
using Depcom.TaberIsla.DataAccess.Context;
using System.Data.Entity;

namespace Depcom.TaberIsla.DataAccess
{
    public class ResponsablesDAO : IResponsablesDAO
    {
        public bool Delete(Responsable item)
        {
            bool result = false;

            using(var db = new DbTaberIsla())
            {
                var registro = GetById(item);
                db.Responsables.Remove(registro);
                result = db.SaveChanges() > 0;
            }

            return result;
        }

        public ICollection<Responsable> GetAll()
        {
            List<Responsable> result = null;

            using(var db = new DbTaberIsla())
            {
                result = db.Responsables.ToList();
            }

            return result;
        }

        public Responsable GetById(Responsable item)
        {
            Responsable registro = null;

            using (var db = new DbTaberIsla())
            {
                registro = db.Responsables.Find(item);
            }

            return registro;
        }

        public Responsable Insert(Responsable item)
        {
            bool result = false;
            Responsable registro = null;

            using (var db = new DbTaberIsla())
            {
                registro = db.Responsables.Add(item);
                result = db.SaveChanges() > 0;
            }

            return result ? registro : null;
        }

        public bool Update(Responsable item)
        {
            bool result = false;

            using(var db = new DbTaberIsla())
            {
                var registroAEditar = db.Responsables.Find(item.Id);
                if (registroAEditar == null) throw new Exception("Registro no encontrado.");

                db.Entry(registroAEditar).State = EntityState.Modified;
                result = db.SaveChanges() > 0;
            }

            return result;
        }
    }
}
