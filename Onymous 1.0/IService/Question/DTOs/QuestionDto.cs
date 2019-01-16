using Service.Base.DTOs;
using System;

namespace IService.Question.DTOs
{
    public class QuestionDto : DtoBase
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public bool Answered { get; set; }

        public bool Anonymous { get; set; }
    }
}
