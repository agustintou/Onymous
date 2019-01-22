using Domain.Repository.UserData;
using Repository;

namespace Infrastructure.Repository.UserData
{
    public class UserDataRepository : Repository<Domain.Entities.UserData>, IUserDataRepository
    {
    }
}
