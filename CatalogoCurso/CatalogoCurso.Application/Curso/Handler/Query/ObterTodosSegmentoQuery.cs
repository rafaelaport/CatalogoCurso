using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Query
{
    public class ObterTodosSegmentoQuery : IRequest<ObterTodosSegmentoQueryResponse>
    {
    }

    public class ObterTodosSegmentoQueryResponse
    {
        public IList<SegmentoOutputDto> Segmentos { get; set; }

        public ObterTodosSegmentoQueryResponse(IList<SegmentoOutputDto> segmentos)
        {
            Segmentos = segmentos;
        }

    }
}
