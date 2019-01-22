using IService.User.DTOs;
using Service.Base.DTOs;
using System;

namespace IService.UserData.DTOs
{
    public class UserDataDto : DtoBase
    {
        public int TotalMessages { get; set; }

        public int MessagesAnswered { get; set; }

        public int MessagesAnonymous { get; set; }

        public DateTime CreationDate { get; set; }

        public int SentMessages { get; set; }

        //Navigation Properties
        public long UserId { get; set; }
    }
}
