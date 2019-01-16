using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Repository.Question;
using IService.Question;
using IService.Question.DTOs;

namespace Service.Question
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public void Add(QuestionDto dto)
        {
            var nowQuestion = new Domain.Entities.Question
            {
                Anonymous = dto.Anonymous,
                Answered = dto.Answered,
                Code = dto.Code,
                Date = dto.Date,
                Message = dto.Message
            };

            _questionRepository.Add(nowQuestion);
            _questionRepository.Save();
        }

        public void Delete(long entityId)
        {
            var question = _questionRepository.GetById(entityId);

            if (question == null)
                throw new Exception("The question was not found");

            _questionRepository.Delete(entityId);

            _questionRepository.Save();
        }

        public QuestionDto GetById(long entityId)
        {
            var question = _questionRepository.GetById(entityId);

            if (question == null)
                throw new Exception("The question was not found");

            return new QuestionDto
            {
                Anonymous = question.Anonymous,
                Answered = question.Answered,
                Code = question.Code,
                Date = question.Date,
                Message = question.Message,
                Id = question.Id,
                RowVersion = question.RowVersion
            };
        }

        public IEnumerable<QuestionDto> GetByString(string stringSearch)
        {
            int code = -1;

            int.TryParse(stringSearch,out code);
            return _questionRepository.GetByFilter(x => x.Message.Contains(stringSearch)
            || x.Code == code)
            .Select(x => new QuestionDto
            {
                Answered = x.Answered,
                Code = x.Code,
                Date = x.Date,
                Message = x.Message,
                Anonymous = x.Anonymous,
                Id = x.Id,
                RowVersion = x.RowVersion
            }).OrderBy(x => x.Date).ThenBy(x => x.Message)
            .ToList();
        }

        public void Update(QuestionDto dto)
        {
            var question = _questionRepository.GetById(dto.Id);

            if (question == null)
                throw new Exception("The question was not found");

            _questionRepository.Update(question);

            question.Message = dto.Message;
            question.Date = dto.Date;

            _questionRepository.Save();
        }
    }
}
