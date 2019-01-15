using IService.User.DTOs;
using System.Collections.Generic;

namespace IService.User
{
    public interface IUserService
    {
        void Add(UserDto dto);

        void Update(UserDto dto);

        void Delete(long entityId);

        UserDto GetById(long entityId);

        IEnumerable<UserDto> GetByString(string stringSearch);
    }
}
