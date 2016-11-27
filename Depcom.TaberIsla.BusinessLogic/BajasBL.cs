using Depcom.TaberIsla.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.DataAccess.Interfaces;
using System.Linq.Expressions;

namespace Depcom.TaberIsla.BusinessLogic
{
    public class BajasBL : IBajasBL
    {
        private readonly IBajasDAO _bajasDAO;
        public BajasBL(IBajasDAO bajasDAO)
        {
            if (bajasDAO == null)
                throw new ArgumentNullException(nameof(bajasDAO));

            _bajasDAO = bajasDAO;
        }
        public void Delete(Baja entity)
        {
            _bajasDAO.Delete(entity);
        }

        public IList<Baja> Find(Expression<Func<Baja, bool>> filter = null)
        {
            return _bajasDAO.Find(filter);
        }

        public IList<Baja> GetAll()
        {
            return _bajasDAO.GetAll();
        }

        public Baja GetByKey(int key)
        {
            return _bajasDAO.GetByKey(key);
        }

        public void Insert(Baja entity)
        {
            _bajasDAO.Insert(entity);
        }

        public void Update(Baja entity)
        {
            _bajasDAO.Update(entity);
        }
    }
}
