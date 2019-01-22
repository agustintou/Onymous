using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Repository.Question;
using Domain.Repository.User;
using IService.Question;
using IService.Question.DTOs;

namespace Service.Question
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IUserRepository _userRepository;

        public QuestionService(IQuestionRepository questionRepository,
            IUserRepository userRepository)
        {
            _questionRepository = questionRepository;
            _userRepository = userRepository;
        }

        public void Add(QuestionDto dto)
        {
            var userAddressee = _userRepository.GetById(dto.UserAddresseeId);

            if (userAddressee == null)
                throw new Exception("No se encontro el usuario destino.");

            var userOrigin = _userRepository.GetById(dto.UserOriginId);

            if (userOrigin == null)
                throw new Exception("No se encontro el usuario origen.");

            var nowQuestion = new Domain.Entities.Question
            {
                Anonymous = dto.Anonymous,
                Answered = dto.Answered,
                Date = dto.Date,
                Description = dto.Description,
                UserAddressee = userAddressee,
                UserOrigin = userOrigin
            };

            _questionRepository.Add(nowQuestion);
            _questionRepository.Save();
        }

        public void Delete(long entityId)
        {
            var question = _questionRepository.GetById(entityId);

            if (question == null)
                throw new Exception("No se encontro la pregunta.");

            _questionRepository.Delete(entityId);

            _questionRepository.Save();
        }

        public QuestionDto GetById(long entityId)
        {
            var question = _questionRepository.GetById(entityId);

            if (question == null)
                throw new Exception("No se encontro la pregunta.");

            return new QuestionDto
            {
                Anonymous = question.Anonymous,
                Answered = question.Answered,
                Date = question.Date,
                Description = question.Description,
                UserAddresseeId = question.UserAddressee.Id,
                UserOriginId = question.UserOrigin.Id,
                Id = question.Id,
                RowVersion = question.RowVersion
            };
        }

        public IEnumerable<QuestionDto> GetByString(string stringSearch)
        {
            return _questionRepository.GetByFilter(x => x.Description.Contains(stringSearch))
            .Select(x => new QuestionDto
            {
                Answered = x.Answered,
                UserOriginId = x.UserOrigin.Id,
                Date = x.Date,
                UserAddresseeId = x.UserAddressee.Id,
                Description = x.Description,
                Anonymous = x.Anonymous,
                Id = x.Id,
                RowVersion = x.RowVersion
            }).OrderBy(x => x.Date).ThenBy(x => x.Description)
            .ToList();
        }

        public IEnumerable<QuestionDto> GetByUser(long entityId)
        {
            var user = _userRepository.GetById(entityId);

            if (user == null)
                throw new Exception("No se encontro el usuario.");

            return _questionRepository.GetByFilter(x => x.UserAddressee.Id == entityId)
                .Select(x => new QuestionDto
                {
                    Anonymous = x.Anonymous,
                    Date = x.Date,
                    Description = x.Description,
                    Answered = x.Answered,
                    Id = x.Id,
                    RowVersion = x.RowVersion,
                    UserOriginId = x.UserOrigin.Id,
                    UserAddresseeId = x.UserAddressee.Id
                }).OrderBy(x => x.Date).ThenBy(x => x.Description)
                .ToList();
        }

        public void Update(QuestionDto dto)
        {
            var question = _questionRepository.GetById(dto.Id);

            if (question == null)
                throw new Exception("No se encontro la pregunta");

            _questionRepository.Update(question);

            question.Description = dto.Description;
            question.Date = dto.Date;
            question.Answered = dto.Answered;
            question.Anonymous = dto.Anonymous;

            _questionRepository.Save();
        }
    }
}
