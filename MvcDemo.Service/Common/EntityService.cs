using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MvcDemo.DataAccess;
using MvcDemo.Common.Entities;


namespace MvcDemo.Service.Common
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        protected IContext _context;
        protected IDbSet<T> _dbset;

        public EntityService(IContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        
        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }
    }
}

