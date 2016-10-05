using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.Repository.Interfaces;

namespace Depcom.TaberIsla.DataAccess
{
    public class ResponsablesDAO : IResponsablesDAO
    {
        private IUnitOfWork _unitOfWork = null;

        public ResponsablesDAO(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));

            _unitOfWork = unitOfWork;
        }
        public void Delete(Responsable entity)
        {
            _unitOfWork.ResponsablesRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public IList<Responsable> GetAll()
        {
            return _unitOfWork.ResponsablesRepository.Get();
        }

        public Responsable GetByKey(int key)
        {
            return _unitOfWork.ResponsablesRepository.GetByKey(r => r.Id == key);
        }

        public Responsable GetByDUI(string dui)
        {
            return _unitOfWork.ResponsablesRepository.Get(r => r.Dui == dui).FirstOrDefault();
        }

        public void Insert(Responsable entity)
        {
            _unitOfWork.ResponsablesRepository.Create(entity);
            _unitOfWork.SaveChanges();
        }

        public void Update(Responsable entity)
        {
            _unitOfWork.ResponsablesRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
