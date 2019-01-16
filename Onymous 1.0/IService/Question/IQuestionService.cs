using IService.Question.DTOs;
using System.Collections.Generic;

namespace IService.Question
{
    public interface IQuestionService
    {
        void Add(QuestionDto dto);

        void Update(QuestionDto dto);

        void Delete(long entityId);

        QuestionDto GetById(long entityId);

        IEnumerable<QuestionDto> GetByString(string stringSearch);
    }
}
