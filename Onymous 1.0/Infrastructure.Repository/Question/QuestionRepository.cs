using Domain.Repository.Question;
using Repository;

namespace Infrastructure.Repository.Question
{
    public class QuestionRepository : Repository<Domain.Entities.Question>, IQuestionRepository
    {
    }
}
