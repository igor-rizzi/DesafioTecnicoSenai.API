using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Colaboradores.Models;
using DesafioTecnicoSenai.API.Common;
using DesafioTecnicoSenai.Application;
using DesafioTecnicoSenai.Domain.Entities.Colaboradores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnicoSenai.API.Areas.Colaboradores.Controllers
{
    [Authorize(Roles = "Administrador")]
    [ApiController]
    [Route("api/[controller]")]
    public class ColaboradorController : CrudController<Colaborador, ColaboradorModel>
    {
        private readonly ICrudService<Colaborador> _colaboradorService;
        private readonly IMapper _mapper;

        public ColaboradorController(ICrudService<Colaborador> colaborador, IMapper mapper)
        {
            _colaboradorService = colaborador;
            _mapper = mapper;
        }
    }
}
