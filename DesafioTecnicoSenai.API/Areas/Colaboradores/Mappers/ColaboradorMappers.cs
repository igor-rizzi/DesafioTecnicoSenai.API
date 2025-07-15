using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Colaboradores.Models;
using DesafioTecnicoSenai.Domain.Entities.Colaboradores;

namespace DesafioTecnicoSenai.API.Areas.Colaboradores.Mappers
{
    public class ColaboradorMappers : Profile
    {
        public ColaboradorMappers()
        {
            CreateMap<Colaborador, ColaboradorModel>()
                .ReverseMap();
        }
    }
}
