using CatalogoCurso.Application.Curso.Dto;
using CatalogoCurso.Application.Curso.Handler.Command;
using CatalogoCurso.Application.Curso.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CursoController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            var result = await _mediator.Send(new ObterTodosCursoQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("obter-por-id/{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var result = await _mediator.Send(new ObterPorIdCursoQuery(id));
            return Ok(result);
        }

        [HttpPost]
        [Route("criar")]
        public async Task<IActionResult> Criar(CursoInputDto dto)
        {
            var result = await _mediator.Send(new CadastrarCursoCommand(dto));
            return Created($"{result.Curso.Id}", result.Curso);
        }

        [HttpPost]
        [Route("editar")]
        public async Task<IActionResult> Editar([FromBody] CursoUpdateDto dto)
        {
            var result = await _mediator.Send(new AtualizarCursoCommand(dto));
            return Ok(result);
        }

        [HttpPost]
        [Route("excluir/{id}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var result = await _mediator.Send(new ExcluirCursoCommand(id));
            return Ok(result);
        }
    }
}
