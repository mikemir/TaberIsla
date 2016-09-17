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
        private IResponsablesRepository _reponsablesRepository = null;

        public ResponsablesDAO(IResponsablesRepository responsablesRepository)
        {
            if (responsablesRepository == null) throw new ArgumentNullException(nameof(responsablesRepository));

            _reponsablesRepository = responsablesRepository;
        }
        public void Delete(Responsable entity)
        {
            _reponsablesRepository.Delete(entity);
        }

        public IList<Responsable> GetAll()
        {
            return _reponsablesRepository.Get();
        }

        public Responsable GetByKey(int key)
        {
            return _reponsablesRepository.GetByKey(r => r.Id == key);
        }

        public void Insert(Responsable entity)
        {
            _reponsablesRepository.Create(entity);
        }

        public void Update(Responsable entity)
        {
            _reponsablesRepository.Update(entity);
        }
    }
}
