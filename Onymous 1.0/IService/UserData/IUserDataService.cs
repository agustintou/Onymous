using IService.UserData.DTOs;
using System.Collections.Generic;

namespace IService.UserData
{
    public interface IUserDataService
    {
        void Add(UserDataDto dto);

        void Update(UserDataDto dto);

        void Delete(long entityId);

        UserDataDto GetById(long entityId);
    }
}
