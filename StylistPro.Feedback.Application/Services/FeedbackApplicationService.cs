using StylistPro.Feedback.Domain.Entities;
using StylistPro.Feedback.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StylistPro.Feedback.Application.Services
{
    public class FeedbackApplicationService : IFeedbackApplicationService
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackApplicationService(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public FeedbackEntity? DeletarDadosFeedback(int id)
        {
            return _feedbackRepository.DeletarDados(id);
        }

        public FeedbackEntity? EditarDadosFeedback(FeedbackEntity entity)
        {
            return _feedbackRepository.EditarDados(entity);
        }

        public FeedbackEntity? ObterFeedbackPorId(int id)
        {
            return _feedbackRepository.ObterPorId(id);
        }

        public IEnumerable<FeedbackEntity> ObterTodosFeedbacks()
        {
            return _feedbackRepository.ObterTodos();
        }

        public FeedbackEntity? SalvarDadosFeedback(FeedbackEntity entity)
        {
            return _feedbackRepository.SalvarDados(entity);
        }
    }
}
