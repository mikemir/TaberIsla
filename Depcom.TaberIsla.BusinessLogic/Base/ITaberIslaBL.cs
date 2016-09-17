﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic.Base
{
    public interface ITaberIslaBL<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();

        TEntity GetByKey(int key);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
