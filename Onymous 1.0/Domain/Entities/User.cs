using Domain.Base;
using Domain.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Users")]
    [MetadataType(typeof(IUser))]
    public class User : EntityBase
    {
        //Properties
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Locked { get; set; }

        //Navigation Properties
    }
}
