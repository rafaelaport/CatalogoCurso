using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Query
{
    public class ObterTodosCursoQuery : IRequest<ObterTodosCursoQueryResponse>
    {
    }

    public class ObterTodosCursoQueryResponse
    {
        public IList<CursoOutputDto> Cursos { get; set; }

        public ObterTodosCursoQueryResponse(IList<CursoOutputDto> cursos)
        {
            Cursos = cursos;
        }

    }
}
