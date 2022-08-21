using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Command
{
    public class CadastrarCursoCommand : IRequest<CadastrarCursoCommandResponse>
    {

        public CursoInputDto Curso { get; set; }

        public CadastrarCursoCommand(CursoInputDto curso)
        {
            Curso = curso;
        }


    }

    public class CadastrarCursoCommandResponse
    {

        public CursoOutputDto Curso { get; set; }

        public CadastrarCursoCommandResponse(CursoOutputDto curso)
        {
            Curso = curso; 
        }

    }
}
