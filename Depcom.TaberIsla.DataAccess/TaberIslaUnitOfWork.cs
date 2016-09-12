﻿using Depcom.TaberIsla.DataAccess.Interfaces;
using Depcom.TaberIsla.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess
{
    public class TaberIslaUnitOfWork : IUnitOfWork, IDisposable
    {
        private IDbContextFactory _contextFactory;
        private DbContext _dbContext;
        private bool _disposed = false;

        public TaberIslaUnitOfWork(IDbContextFactory contextFactory)
        {
            if (contextFactory == null)
                throw new ArgumentNullException(nameof(contextFactory));

            _contextFactory = contextFactory;
            _dbContext = contextFactory.GetDbContext();
        }

        public IResponsablesRepository ResposablesRepository
        {
            get
            {
                return new ResponsableRepository(_dbContext);
            }
        }

        public string UserName { get; set; }

        public virtual void SaveChanges()
        {
            SaveChanges(this.UserName ?? "NO_USER");
        }

        public void SaveChanges(string currentUserName)
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this._dbContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
