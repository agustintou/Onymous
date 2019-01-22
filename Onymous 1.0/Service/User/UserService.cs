using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Repository.Person;
using Domain.Repository.User;
using IService.User;
using IService.User.DTOs;

namespace Service.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPersonRepository _personRepository;

        public UserService(IUserRepository userRepository,
            IPersonRepository personRepository)
        {
            _userRepository = userRepository;
            _personRepository = personRepository;
        }

        public void Add(UserDto dto)
        {
            var person = _personRepository.GetById(dto.PersonId);

            if (person == null)
                throw new Exception("No se encontro la persona.");

            var nowUser = new Domain.Entities.User
            {
                Locked = dto.Locked,
                Password = dto.Password,
                UserName = dto.UserName,
                Person = person
            };

            _userRepository.Add(nowUser);
            _userRepository.Save();
        }

        public void Delete(long entityId)
        {
            var user = _userRepository.GetById(entityId);

            if (user == null)
                throw new Exception("No se encontro el usuario.");

            _userRepository.Delete(entityId);

            _userRepository.Save();
        }

        public UserDto GetByAccount(string userName, string password)
        {
            var user = _userRepository.GetByAccount(userName, password);

            if(user != null)
            {
                return new UserDto
                {
                    Id = user.Id,
                    Locked = user.Locked,
                    Password = user.Password,
                    RowVersion = user.RowVersion,
                    UserName = user.UserName,
                    PersonId = user.Person.Id
                };
            }

            return null;
        }

        public UserDto GetById(long entityId)
        {
            var user = _userRepository.GetById(entityId);

            if (user == null)
                throw new Exception("No se encontro el usuario.");

            return new UserDto
            {
                Id = user.Id,
                Locked = user.Locked,
                Password = user.Password,
                RowVersion = user.RowVersion,
                UserName = user.UserName,
                PersonId = user.Person.Id
            };
        }

        public void Update(UserDto dto)
        {
            var user = _userRepository.GetById(dto.Id);

            if (user == null)
                throw new Exception("No se encontro el usuario.");

            _userRepository.Update(user);

            user.Password = dto.Password;
            user.UserName = dto.UserName;
            user.Locked = dto.Locked;

            _userRepository.Save();
        }
    }
}
