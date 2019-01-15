using Domain.Base;
using Domain.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Persons")]
    [MetadataType(typeof(IPerson))]
    public class Person : EntityBase
    {
        //Properties
        public string FullName { get; set; }

        public string Email { get; set; }

        public byte[] Image { get; set; }

        public string Phone { get; set; }

        //Navigation Properties

    }
}
