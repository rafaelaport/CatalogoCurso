using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Command
{
    public class ExcluirCursoCommand : IRequest<ExcluirCursoCommandResponse>
    {
        public Guid Id { get; set; }

        public ExcluirCursoCommand(Guid id)
        {
            Id = id;
        }
    }

    public class ExcluirCursoCommandResponse
    {
        public CursoOutputDto Curso { get; set; }

        public ExcluirCursoCommandResponse(CursoOutputDto curso)
        {
            Curso = curso;
        }
    }
}
