using IService.Person.DTOs;
using Service.Base.DTOs;

namespace IService.User.DTOs
{
    public class UserDto : DtoBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Locked { get; set; }

        public PersonDto Person { get; set; }
    }
}
