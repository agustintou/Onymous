using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Repository.User;
using IService.User;
using IService.User.DTOs;

namespace Service.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(UserDto dto)
        {
            var nowUser = new Domain.Entities.User
            {
                Locked = dto.Locked,
                Password = dto.Password,
                UserName = dto.UserName
            };

            _userRepository.Add(nowUser);
            _userRepository.Save();
        }

        public void Delete(long entityId)
        {
            var user = _userRepository.GetById(entityId);

            if (user == null)
                throw new Exception("The user was not found");

            _userRepository.Delete(entityId);

            _userRepository.Save();
        }

        public UserDto GetById(long entityId)
        {
            var user = _userRepository.GetById(entityId);

            if (user == null)
                throw new Exception("The user was not found");

            return new UserDto
            {
                Id = user.Id,
                Locked = user.Locked,
                Password = user.Password,
                RowVersion = user.RowVersion,
                UserName = user.UserName
            };
        }

        public IEnumerable<UserDto> GetByString(string stringSearch)
        {
            return _userRepository.GetByFilter(x => x.UserName.Contains(stringSearch))
            .Select(x => new UserDto
            {
                Locked = x.Locked,
                Password = x.Password,
                UserName = x.UserName,
                Id = x.Id,
                RowVersion = x.RowVersion
            }).OrderBy(x => x.UserName)
            .ToList();
        }

        public void Update(UserDto dto)
        {
            var user = _userRepository.GetById(dto.Id);

            if (user == null)
                throw new Exception("The user was not found");

            _userRepository.Update(user);

            user.Password = dto.Password;
            user.UserName = dto.UserName;
            user.Locked = dto.Locked;

            _userRepository.Save();
        }
    }
}
