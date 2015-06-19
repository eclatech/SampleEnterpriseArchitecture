using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.DataAccess.Implementation;
using Sample.Objects;

namespace Sample.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        User Add(User entity);

        User GetUserById(long id);
    }
}
