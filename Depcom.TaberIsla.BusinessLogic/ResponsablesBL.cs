using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.DataAccess;
using Depcom.TaberIsla.DataAccess.Interfaces;
using Depcom.TaberIsla.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic
{
    public class ResponsablesBL : IResponsablesBL
    {
        private IUnitOfWork _uow;
        public ResponsablesBL(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));

            _uow = unitOfWork;
        }

        public void Delete(Responsable item)
        {
            try
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item));

                _uow.ResposablesRepository.Delete(item);
                _uow.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<Responsable> GetAll()
        {
            try
            {
                var responsables = _uow.ResposablesRepository.Get();
                return responsables;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Responsable GetById(Responsable item)
        {
            try
            {
                var responsable = _uow.ResposablesRepository.GetByKey(r => r.Id == item.Id);
                return responsable;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(Responsable item)
        {
            try
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item));

                _uow.ResposablesRepository.Create(item);
                _uow.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Responsable item)
        {
            try
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item));

                _uow.ResposablesRepository.Update(item);
                _uow.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
