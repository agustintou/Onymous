using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Repository.Person;
using IService.Person;
using IService.Person.DTOs;

namespace Service.Person
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void Add(PersonDto dto)
        {
            var nowPerson = new Domain.Entities.Person
            {
                Email = dto.Email,
                FullName = dto.FullName,
                Image = dto.Image,
                Phone = dto.Phone
            };

            _personRepository.Add(nowPerson);
            _personRepository.Save();
        }

        public void Delete(long entityId)
        {
            var person = _personRepository.GetById(entityId);

            if (person == null)
                throw new Exception("The person was not found");

            _personRepository.Delete(entityId);

            _personRepository.Save();
        }

        public PersonDto GetById(long entityId)
        {
            var person = _personRepository.GetById(entityId);

            if (person == null)
                throw new Exception("The person was not found");

            return new PersonDto
            {
                Email = person.Email,
                FullName = person.FullName,
                Id = person.Id,
                Image = person.Image,
                Phone = person.Phone,
                RowVersion = person.RowVersion
            };
        }

        public IEnumerable<PersonDto> GetByString(string stringSearch)
        {
            return _personRepository.GetByFilter(x => x.FullName.Contains(stringSearch)
            || x.Email.Contains(stringSearch)
            || x.Phone.Contains(stringSearch))
            .Select(x => new PersonDto
            {
                Email = x.Email,
                FullName = x.FullName,
                Id = x.Id,
                Image = x.Image,
                Phone = x.Phone,
                RowVersion = x.RowVersion
            }).OrderBy(x => x.FullName).ThenBy(x => x.Email)
            .ToList();
        }

        public void Update(PersonDto dto)
        {
            var person = _personRepository.GetById(dto.Id);

            if (person == null)
                throw new Exception("The person was not found");

            _personRepository.Update(person);

            person.FullName = dto.FullName;
            person.Email = dto.Email;
            person.Phone = dto.Phone;
            person.Image = dto.Image;

            _personRepository.Save();
        }
    }
}
