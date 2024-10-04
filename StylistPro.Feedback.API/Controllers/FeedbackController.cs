using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StylistPro.Feedback.Domain.Entities;
using StylistPro.Feedback.Domain.Interfaces;

namespace StylistPro.Feedback.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackApplicationService _feedbackApplicationService;

        public FeedbackController(IFeedbackApplicationService feedbackApplicationService)
        {
            _feedbackApplicationService = feedbackApplicationService;
        }

        /// <summary>
        /// Método para obter todos os dados de feedbacks
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<FeedbackEntity>>]
        public IActionResult Get()
        {
            var feedbacks = _feedbackApplicationService.ObterTodosFeedbacks();

            if (feedbacks is not null)
                return Ok(feedbacks);

            return BadRequest("Não foi possível obter os dados");
        }

        /// <summary>
        /// Método para obter um feedback
        /// </summary>
        /// <param name="id">Identificador do feedback</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<FeedbackEntity>]

        public IActionResult GetPorId(int id)
        {
            var feedbacks = _feedbackApplicationService.ObterFeedbackPorId(id);

            if (feedbacks is not null)
                return Ok(feedbacks);

            return BadRequest("Não foi possível obter os dados");
        }

        /// <summary>
        /// Métodos para salvar o feedback
        /// </summary>
        /// <param name="entity">Modelo de dados do Feedback</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<FeedbackEntity>]
        public IActionResult Post(FeedbackEntity entity)
        {
            var feedbacks = _feedbackApplicationService.SalvarDadosFeedback(entity);

            if (feedbacks is not null)
                return Ok(feedbacks);

            return BadRequest("Não foi possível salvar os dados");
        }

        /// <summary>
        /// Métodos para editar o feedback
        /// </summary>
        /// <param name="entity">Modelo de dados do Feedback</param>
        /// <returns></returns>
        [HttpPut]
        [Produces<FeedbackEntity>]
        public IActionResult Put(FeedbackEntity entity)
        {
            var feedbacks = _feedbackApplicationService.EditarDadosFeedback(entity);

            if (feedbacks is not null)
                return Ok(feedbacks);

            return BadRequest("Não foi possível editar os dados");
        }

        /// <summary>
        /// Método para deletar um feedback
        /// </summary>
        /// <param name="id">Identificador do feedback</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<FeedbackEntity>]

        public IActionResult Delete(int id)
        {
            var feedbacks = _feedbackApplicationService.DeletarDadosFeedback(id);

            if (feedbacks is not null)
                return Ok(feedbacks);

            return BadRequest("Não foi possível deletar os dados");
        }
    }
}
