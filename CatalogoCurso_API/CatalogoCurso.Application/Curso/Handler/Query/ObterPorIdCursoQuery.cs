using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Query
{
    public class ObterPorIdCursoQuery : IRequest<ObterPorIdCursoQueryResponse>
    {
        public Guid Id { get; set; }

        public ObterPorIdCursoQuery(Guid id)
        {
            Id = id;
        }
    }

    public class ObterPorIdCursoQueryResponse
    {
        public CursoOutputDto Curso { get; set; }

        public ObterPorIdCursoQueryResponse(CursoOutputDto curso)
        {
            Curso = curso;
        }

    }
}
