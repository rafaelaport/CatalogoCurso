using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Query
{
    public class ObterTodosModalidadeEducacaoQuery : IRequest<ObterTodosModalidadeEducacaoQueryResponse>
    {
    }

    public class ObterTodosModalidadeEducacaoQueryResponse
    {
        public IList<ModalidadeEducacaoOutputDto> ModalidadesEducacao { get; set; }

        public ObterTodosModalidadeEducacaoQueryResponse(IList<ModalidadeEducacaoOutputDto> modalidadesEducacao)
        {
            ModalidadesEducacao = modalidadesEducacao;
        }

    }
}
