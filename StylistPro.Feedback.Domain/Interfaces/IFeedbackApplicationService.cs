using StylistPro.Feedback.Domain.Entities;

namespace StylistPro.Feedback.Domain.Interfaces
{
    public interface IFeedbackApplicationService
    { 
    IEnumerable<FeedbackEntity> ObterTodosFeedbacks();
    FeedbackEntity? ObterFeedbackPorId(int id);
    FeedbackEntity? SalvarDadosFeedback(FeedbackEntity entity);
    FeedbackEntity? EditarDadosFeedback(FeedbackEntity entity);
    FeedbackEntity? DeletarDadosFeedback(int id);
    }
}