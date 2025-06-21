using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Administracao.Models;
using DesafioTecnicoSenai.Domain.Entities.Administracao;

namespace DesafioTecnicoSenai.API.Areas.Administracao.Mappers
{
    public class AdministracaoMappers : Profile
    {
        public AdministracaoMappers()
        {
            CargoMappers();
            FuncaoMappers();
            TipoDespesaMappers();
        }

        private void TipoDespesaMappers()
        {
            CreateMap<TipoDespesaModel, TipoDespesa>()
                .ReverseMap();
        }

        private void CargoMappers()
        {
            CreateMap<CargoModel, Cargo>()
                .ReverseMap();
        }

        private void FuncaoMappers()
        {
            CreateMap<FuncaoModel, Funcao>()
               .ReverseMap();
        }
    }
}
