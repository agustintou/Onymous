using Domain.Repository.User;
using Repository;

namespace Infrastructure.Repository.User
{
    public class UserRepository : Repository<Domain.Entities.User>, IUserRepository
    {
    }
}
