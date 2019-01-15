using IService.Person.DTOs;
using System.Collections.Generic;

namespace IService.Person
{
    public interface IPersonService
    {
        void Add(PersonDto dto);

        void Update(PersonDto dto);

        void Delete(long entityId);

        PersonDto GetById(long entityId);

        IEnumerable<PersonDto> GetByString(string stringSearch);
    }
}
