using CatalogoCurso.Application.Curso.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EixoTecnologicoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EixoTecnologicoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            var result = await _mediator.Send(new ObterTodosEixoTecnologicoQuery());
            return Ok(result);
        }
    }
}
