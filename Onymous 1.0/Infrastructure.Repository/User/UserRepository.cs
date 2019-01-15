using Domain.Entities;
using Domain.Repository.User;
using Infrastructure.Context;
using Repository;
using System.Linq;

namespace Infrastructure.Repository.User
{
    public class UserRepository : Repository<Domain.Entities.User>, IUserRepository
    {
        public Domain.Entities.User GetByAccount(string userName, string password)
        {
            return Context.Users.FirstOrDefault(x => x.UserName == userName
            && x.Password == password);
        }
    }
}
