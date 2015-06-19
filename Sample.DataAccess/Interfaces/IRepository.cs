using System;
using System.Collections.Generic;
using Sample.Objects;

namespace Sample.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        ICollection<T> GetAll(Func<T, bool> expression = null);

        T GetById(long id);

        T Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);
    }
}
