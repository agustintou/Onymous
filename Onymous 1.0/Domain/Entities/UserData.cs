using Domain.Base;
using Domain.MetaData;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("UserDatas")]
    [MetadataType(typeof(IUserData))]
    public class UserData : EntityBase
    {
        public int TotalMessages { get; set; }

        public int MessagesAnswered { get; set; }

        public int MessagesAnonymous { get; set; }

        public DateTime CreationDate { get; set; }

        public int SentMessages { get; set; }

        //Navigation Properties
        public virtual User User { get; set; }
    }
}
