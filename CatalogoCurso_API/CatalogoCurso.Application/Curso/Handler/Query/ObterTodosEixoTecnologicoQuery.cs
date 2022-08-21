using CatalogoCurso.Application.Curso.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler.Query
{
    public class ObterTodosEixoTecnologicoQuery : IRequest<ObterTodosEixoTecnologicoQueryResponse>
    {
    }

    public class ObterTodosEixoTecnologicoQueryResponse
    {
        public IList<EixoTecnologicoOutputDto> EixosTecnologico { get; set; }

        public ObterTodosEixoTecnologicoQueryResponse(IList<EixoTecnologicoOutputDto> eixosTecnologico)
        {
            EixosTecnologico = eixosTecnologico;
        }

    }
}
