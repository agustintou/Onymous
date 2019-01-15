using Domain.Base;

namespace Repository.Base
{
    public interface IRepository<T> : IRepositoryPersistence<T>, IRepositoryQuery<T> where T : EntityBase
    {

    }
}
