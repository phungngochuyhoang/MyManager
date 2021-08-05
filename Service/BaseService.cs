using System.Collections.Generic;
using System.Linq;
using System;
using Manager.Data;
using Microsoft.EntityFrameworkCore;
using Manager.Service;

namespace Manager.DBContext.Repository
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IRepositoryBase<T> _reponsitory;
        public BaseService(IRepositoryBase<T> reponsitory)
        {
            _reponsitory = reponsitory;
        }
        public T GetById(object id)
        {
            return _reponsitory.GetById(id);
        }

        public void Insert(T entity) {
            _reponsitory.Insert(entity);
        }
    }

}