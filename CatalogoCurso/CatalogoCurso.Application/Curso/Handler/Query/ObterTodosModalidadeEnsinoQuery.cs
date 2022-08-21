using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Query
{
    public class ObterTodosModalidadeEnsinoQuery : IRequest<ObterTodosModalidadeEnsinoQueryResponse>
    {
    }

    public class ObterTodosModalidadeEnsinoQueryResponse
    {
        public IList<ModalidadeEnsinoOutputDto> ModalidadesEnsino { get; set; }

        public ObterTodosModalidadeEnsinoQueryResponse(IList<ModalidadeEnsinoOutputDto> modalidadesEnsino)
        {
            ModalidadesEnsino = modalidadesEnsino;
        }

    }
}
