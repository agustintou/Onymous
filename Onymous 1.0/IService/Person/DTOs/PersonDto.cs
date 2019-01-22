using Service.Base.DTOs;

namespace IService.Person.DTOs
{
    public class PersonDto : DtoBase
    {
        //Properties
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public byte[] Photo { get; set; }
    }
}
