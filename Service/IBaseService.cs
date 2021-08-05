using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Manager.Data;

namespace Manager.Service
{
    public interface IBaseService<T> where T : IBaseEntity
    {
        T GetById(object id);

        void Insert(T entity);
    }
    
}