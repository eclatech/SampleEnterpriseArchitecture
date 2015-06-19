using Sample.Objects;

namespace Sample.Business.Interfaces
{
    public interface IUserBusiness
    {
        User GetUserById(long id);

        User AddUser(User entity);
    }
}
