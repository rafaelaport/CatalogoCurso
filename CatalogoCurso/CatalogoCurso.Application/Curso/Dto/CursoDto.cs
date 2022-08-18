using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Dto
{
    public record CursoInputDto(
        string Nome,
        int CargaHoraria,
        string Objetivo,
        string Bibliografia,
        string Avaliacao,
        string Certificacao,
        Guid ModalidadeEnsino,
        Guid TipoCurso,
        Guid ModalidadeEducacao,
        Guid EixoTecnologico,
        Guid Segmento);

    public record CursoOutputDto(
        Guid Id,
        string Nome,
        int CargaHoraria,
        string Objetivo,
        string Bibliografia,
        string Avaliacao,
        string Certificacao,
        Guid ModalidadeEnsino,
        Guid TipoCurso,
        Guid ModalidadeEducacao,
        Guid EixoTecnologico,
        Guid Segmento);

    public record CursoUpdateDto(
        Guid Id,
        string Nome,
        int CargaHoraria,
        string Objetivo,
        string Bibliografia,
        string Avaliacao,
        string Certificacao,
        Guid ModalidadeEnsino,
        Guid TipoCurso,
        Guid ModalidadeEducacao,
        Guid EixoTecnologico,
        Guid Segmento);
}