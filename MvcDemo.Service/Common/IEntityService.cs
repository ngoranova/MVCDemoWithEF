using System;
using System.Collections.Generic;
using MvcDemo.Common.Entities;

namespace MvcDemo.Service.Common
{
    public interface IEntityService<T> : IService
    where T : BaseEntity
    {
        IEnumerable<T> GetAll();
    }
}
