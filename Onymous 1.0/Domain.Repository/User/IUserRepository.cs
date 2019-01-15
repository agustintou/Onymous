using Repository.Base;

namespace Domain.Repository.User
{
    public interface IUserRepository : IRepository<Entities.User>
    {
        Entities.User GetByAccount(string userName, string password);
    }
}
