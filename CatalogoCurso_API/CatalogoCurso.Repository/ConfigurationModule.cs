using CatalogoCurso.Domain.Curso.Repository;
using CatalogoCurso.Repository.Context;
using CatalogoCurso.Repository.Database;
using CatalogoCurso.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CatalogoCursoContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IEixoTecnologicoRepository, EixoTecnologicoRepository>();
            services.AddScoped<IModalidadeEducacaoRepository, ModalidadeEducacaoRepository>();
            services.AddScoped<IModalidadeEnsinoRepository, ModalidadeEnsinoRepository>();
            services.AddScoped<ISegmentoRepository, SegmentoRepository>();
            services.AddScoped<ITipoCursoRepository, TipoCursoRepository>();

            return services;
        }
    }
}
