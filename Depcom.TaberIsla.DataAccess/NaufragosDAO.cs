﻿using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using System.Linq.Expressions;

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

        public int Count(Expression<Func<Naufrago, bool>> filter = null)
        {
            return _unitOfWork.NaufragosRepository.Get(filter).Count();
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

        public IList<Naufrago> Find(string value)
        {
            int correlativo = 0;
            int.TryParse(value, out correlativo);

            return _unitOfWork.NaufragosRepository.Get(n => n.Correlativo == correlativo ||
                                                            n.Nombres.Contains(value) ||
                                                            n.Apellidos.Contains(value));
        }

        public IList<Naufrago> GetAll()
        {
            return _unitOfWork.NaufragosRepository.Get(includes: n => n.Responsable);
        }

        public Naufrago GetByKey(int key)
        {
            return _unitOfWork.NaufragosRepository.GetByKey(n => n.Id == key, n => n.Responsable, n => n.Medicamentos);
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
