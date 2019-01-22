using Domain.Repository.User;
using Domain.Repository.UserData;
using IService.UserData;
using IService.UserData.DTOs;

namespace Service.UserData
{
    public class UserDataService : IUserDataService
    {
        private readonly IUserDataRepository _userDataRepository;
        private readonly IUserRepository _userRepository;

        public UserDataService(IUserDataRepository userDataRepository,
            IUserRepository userRepository)
        {
            _userDataRepository = userDataRepository;
            _userRepository = userRepository;
        }


        public void Add(UserDataDto dto)
        {
            var user = _userRepository.GetById(dto.UserId);

            if (user == null)
                throw new System.Exception("No se encontro el usuario.");

            var nowUserData = new Domain.Entities.UserData
            {
                CreationDate = dto.CreationDate,
                MessagesAnswered = dto.MessagesAnswered,
                MessagesAnonymous = dto.MessagesAnonymous,
                SentMessages = dto.SentMessages,
                TotalMessages = dto.TotalMessages,
                User = user
            };

            _userDataRepository.Add(nowUserData);
            _userDataRepository.Save();
        }

        public void Delete(long entityId)
        {
            _userDataRepository.Delete(entityId);
        }

        public void Update(UserDataDto dto)
        {
            var userData = _userDataRepository.GetById(dto.Id);

            if (userData == null)
                throw new System.Exception("No se encontro los datos del usuario.");

            _userDataRepository.Update(userData);

            userData.MessagesAnonymous = dto.MessagesAnonymous;
            userData.MessagesAnswered = dto.MessagesAnswered;
            userData.SentMessages = dto.SentMessages;
            userData.TotalMessages = dto.TotalMessages;

            _userDataRepository.Save();
        }

        UserDataDto IUserDataService.GetById(long entityId)
        {
            var userData = _userDataRepository.GetById(entityId);

            if (userData == null)
                throw new System.Exception("No se encontro los datos del usuario.");

            return new UserDataDto
            {
                CreationDate = userData.CreationDate,
                MessagesAnswered = userData.MessagesAnswered,
                RowVersion = userData.RowVersion,
                SentMessages = userData.SentMessages,
                TotalMessages = userData.TotalMessages,
                UserId = userData.User.Id,
                MessagesAnonymous = userData.MessagesAnonymous,
                Id = userData.Id
            };
        }
    }
}
