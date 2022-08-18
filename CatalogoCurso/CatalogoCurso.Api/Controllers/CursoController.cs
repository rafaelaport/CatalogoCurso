using CatalogoCurso.Domain.Curso.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {

        public ICursoRepository CursoRepository { get; }

        public CursoController(ICursoRepository cursoRepository) 
        {
            CursoRepository = cursoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.CursoRepository.ObterTodos());
        }
    }
}
