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
        string? Objetivo,
        string? Bibliografia,
        string? Avaliacao,
        string? Certificacao,
        Guid ModalidadeEnsinoId,
        Guid TipoCursoId,
        Guid ModalidadeEducacaoId,
        Guid EixoTecnologicoId,
        Guid SegmentoId);

    public record CursoOutputDto(
        Guid Id,
        string Nome,
        int CargaHoraria,
        string Objetivo,
        string Bibliografia,
        string Avaliacao,
        string Certificacao,
        Guid ModalidadeEnsinoId,
        Guid TipoCursoId,
        Guid ModalidadeEducacaoId,
        Guid EixoTecnologicoId,
        Guid SegmentoId,
        DateTime DataAtualizacao,
        DateTime DataCadastro,
        bool Ativo);

    public record CursoUpdateDto(
        Guid Id,
        string Nome,
        int CargaHoraria,
        string? Objetivo,
        string? Bibliografia,
        string? Avaliacao,
        string? Certificacao,
        Guid ModalidadeEnsinoId,
        Guid TipoCursoId,
        Guid ModalidadeEducacaoId,
        Guid EixoTecnologicoId,
        Guid SegmentoId);

    public record EixoTecnologicoOutputDto(
        Guid Id,
        string Descricao,
        DateTime DataCadastro,
        bool Ativo);

    public record ModalidadeEducacaoOutputDto(
        Guid Id,
        string Descricao,
        DateTime DataCadastro,
        bool Ativo);

    public record ModalidadeEnsinoOutputDto(
    Guid Id,
    string Descricao,
    DateTime DataCadastro,
    bool Ativo);

    public record SegmentoOutputDto(
    Guid Id,
    string Descricao,
    DateTime DataCadastro,
    bool Ativo);

    public record TipoCursoOutputDto(
    Guid Id,
    string Descricao,
    DateTime DataCadastro,
    bool Ativo);
}