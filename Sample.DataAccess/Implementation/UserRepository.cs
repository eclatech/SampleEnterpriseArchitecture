using Sample.DataAccess.Interfaces;
using Sample.Objects;

namespace Sample.DataAccess.Implementation
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base("test")
        {
            
        }

        public User GetUserById(long id)
        {
            return GetById(id);
        }
    }
}
