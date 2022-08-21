using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Command
{
    public class AtualizarCursoCommand : IRequest<AtualizarCursoCommandResponse>
    {
        public CursoUpdateDto Curso { get; set; }

        public AtualizarCursoCommand(CursoUpdateDto curso)
        {
            Curso = curso;
        }
    }

    public class AtualizarCursoCommandResponse
    {
        public CursoOutputDto Curso { get; set; }

        public AtualizarCursoCommandResponse(CursoOutputDto curso)
        {
            Curso = curso;
        }
    }
}
