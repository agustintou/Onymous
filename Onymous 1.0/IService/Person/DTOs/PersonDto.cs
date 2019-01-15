using Service.Base.DTOs;

namespace IService.Person.DTOs
{
    public class PersonDto : DtoBase
    {
        //Properties
        public string FullName { get; set; }

        public string Email { get; set; }

        public byte[] Image { get; set; }

        public string Phone { get; set; }

        //Navigation Properties
    }
}
