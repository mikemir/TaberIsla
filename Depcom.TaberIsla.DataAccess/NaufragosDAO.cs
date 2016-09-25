using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;

namespace Depcom.TaberIsla.DataAccess
{
    public class NaufragosDAO : INaufragosDAO
    {
        private IUnitOfWork _unitOfWork;

        public NaufragosDAO(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));

            _unitOfWork = unitOfWork;
        }
        public void Delete(Naufrago entity)
        {
            _unitOfWork.NaufragosRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public IList<Naufrago> GetAll()
        {
            return _unitOfWork.NaufragosRepository.Get();
        }

        public Naufrago GetByKey(int key)
        {
            return _unitOfWork.NaufragosRepository.GetByKey(n => n.Id == key);
        }

        public void Insert(Naufrago entity)
        {
            _unitOfWork.NaufragosRepository.Create(entity);
            _unitOfWork.SaveChanges();
        }

        public void Update(Naufrago entity)
        {
            _unitOfWork.NaufragosRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
