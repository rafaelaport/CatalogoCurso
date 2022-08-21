using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Query
{
    public class ObterTodosTipoCursoQuery : IRequest<ObterTodosTipoCursoQueryResponse>
    {
    }

    public class ObterTodosTipoCursoQueryResponse
    {
        public IList<TipoCursoOutputDto> TipoCursos { get; set; }

        public ObterTodosTipoCursoQueryResponse(IList<TipoCursoOutputDto> tipoCursos)
        {
            TipoCursos = tipoCursos;
        }

    }
}
