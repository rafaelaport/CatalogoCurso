using CatalogoCurso.Application.Curso.Dto;
using CatalogoCurso.Domain.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Profile
{
    public class CursoProfile: AutoMapper.Profile
    {
        public CursoProfile()
        {
            CreateMap<Domain.Curso.Curso, CursoOutputDto>();
            CreateMap<CursoInputDto, Domain.Curso.Curso>();                
            CreateMap<CursoUpdateDto, Domain.Curso.Curso>();

            CreateMap<EixoTecnologico, EixoTecnologicoOutputDto>();
            CreateMap<ModalidadeEducacao, ModalidadeEducacaoOutputDto>();
            CreateMap<ModalidadeEnsino, ModalidadeEnsinoOutputDto>();
            CreateMap<Segmento, SegmentoOutputDto>();
            CreateMap<TipoCurso, TipoCursoOutputDto>();
        }
    }
}
