using Service.Base.DTOs;
using System;

namespace IService.Question.DTOs
{
    public class QuestionDto : DtoBase
    {
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public bool Answered { get; set; }

        public bool Anonymous { get; set; }

        //Navigation Properties
        public long UserAddresseeId { get; set; }

        public long UserOriginId { get; set; }

    }
}
