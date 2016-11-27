using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using System.Linq.Expressions;

namespace Depcom.TaberIsla.DataAccess
{
    public class BajasDAO : IBajasDAO
    {
        private IUnitOfWork _unitOfWork;

        public BajasDAO(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));

            _unitOfWork = unitOfWork;
        }

        public void Delete(Baja entity)
        {
            _unitOfWork.BajasRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public IList<Baja> Find(Expression<Func<Baja, bool>> filter = null)
        {
            return _unitOfWork.BajasRepository.Get(filter);
        }

        public IList<Baja> GetAll()
        {
            return _unitOfWork.BajasRepository.Get();
        }

        public Baja GetByKey(int key)
        {
            return _unitOfWork.BajasRepository.GetByKey(b => b.Id == key);
        }

        public void Insert(Baja entity)
        {
            _unitOfWork.BajasRepository.Create(entity);
            _unitOfWork.SaveChanges();
        }

        public void Update(Baja entity)
        {
            _unitOfWork.BajasRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
