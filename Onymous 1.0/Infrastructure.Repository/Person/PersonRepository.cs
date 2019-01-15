using Domain.Repository.Person;
using Repository;

namespace Infrastructure.Repository.Person
{
    public class PersonRepository : Repository<Domain.Entities.Person>, IPersonRepository
    {

    }
}
