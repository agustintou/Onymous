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
        public int Code { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public bool Answered { get; set; }

        public bool Anonymous { get; set; }

        //Properties Navigation
        public virtual Person PersonOrigin { get; set; }

        public virtual Person PersonDestination { get; set; }
    }
}
