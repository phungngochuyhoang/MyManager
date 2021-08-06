using System.Collections.Generic;
using System.Linq;
using System;
using Manager.Data;
using Microsoft.EntityFrameworkCore;


namespace Manager.DBContext.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private readonly MyDataDbContext _context; 
        private readonly DbSet<T> _entities;
        public RepositoryBase(MyDataDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public T GetById(object id)
        {
            return _entities.Find(id);
        }

        public void Insert(T entity) 
        {
            _entities.Add(entity); 
            _context.SaveChanges();
        }
    }

}