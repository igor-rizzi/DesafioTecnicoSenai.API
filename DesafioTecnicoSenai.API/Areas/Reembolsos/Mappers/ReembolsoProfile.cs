using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Reembolsos.Models;
using DesafioTecnicoSenai.Domain.Entities.Reembolsos;

namespace DesafioTecnicoSenai.API.Areas.Reembolsos.Mappers
{
    public class ReembolsoProfile : Profile
    {
        public ReembolsoProfile()
        {
            CreateMap<ReembolsoModel, Reembolso>()
                .ForMember(dest => dest.Colaborador, opt => opt.Ignore())
                .ForMember(dest => dest.TipoDespesa, opt => opt.Ignore());

            CreateMap<Reembolso, ReembolsoModel>();
        }
    }
}