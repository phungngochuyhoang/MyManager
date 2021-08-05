using System.Collections.Generic;
using System.Linq;
using System;
using Manager.Data;

namespace Manager.DBContext.Repository
{
    public interface IRepositoryBase<T> where T : IBaseEntity
    {
        T GetById(object id);


    }

}