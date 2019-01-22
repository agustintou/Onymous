using Domain.Base;
using Domain.MetaData;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Questions")]
    [MetadataType(typeof(IQuestion))]
    public class Question : EntityBase
    {
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public bool Answered { get; set; }

        public bool Anonymous { get; set; }

        //Properties Navigation
        public virtual User UserAddressee { get; set; }

        public virtual User UserOrigin { get; set; }
    }
}
