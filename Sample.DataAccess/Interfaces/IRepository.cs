using System.Collections.Generic;
using Sample.Objects;

namespace Sample.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        ICollection<T> GetAll();

        T GetById(long id);
    }
}
