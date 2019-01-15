using Domain.Base;

namespace Repository.Base
{
    public interface IRepositoryPersistence<T> where T : EntityBase
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(long id);

        void Save();
    }
}
