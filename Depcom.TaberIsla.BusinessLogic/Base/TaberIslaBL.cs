using Depcom.TaberIsla.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic.Base
{
    public class TaberIslaBL<TEntity> : ITaberIslaBL<TEntity> where TEntity : class
    {
        private ITaberIslaDAO<TEntity> _taberIslaDao = null;

        public TaberIslaBL(ITaberIslaDAO<TEntity> taberIslaDao)
        {
            if (taberIslaDao == null)
                throw new ArgumentNullException(nameof(taberIslaDao));

            _taberIslaDao = taberIslaDao;
        }
        public void Delete(TEntity entity)
        {
            _taberIslaDao.Delete(entity);
        }

        public IList<TEntity> GetAll()
        {
            return _taberIslaDao.GetAll();
        }

        public TEntity GetByKey(int key)
        {
            return _taberIslaDao.GetByKey(key);
        }

        public void Insert(TEntity entity)
        {
            _taberIslaDao.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _taberIslaDao.Update(entity);
        }
    }
}
