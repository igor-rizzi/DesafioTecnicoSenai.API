using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Usuarios.Models;
using DesafioTecnicoSenai.Domain.Entities.Usuarios;
using DesafioTecnicoSenai.InfraData.Models.Autenticacao;

namespace DesafioTecnicoSenai.API.Areas.Usuarios.Mappers
{
    public class UsuarioMappers : Profile
    {
        public UsuarioMappers()
        {
            CreateMap<UsuarioModel, Usuario>()
                .ReverseMap();

        }
    }
}
