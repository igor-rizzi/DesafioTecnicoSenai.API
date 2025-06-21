using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Administracao.Models;
using DesafioTecnicoSenai.API.Common;
using DesafioTecnicoSenai.Application.Interfaces.Services;
using DesafioTecnicoSenai.Domain.Entities.Administracao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnicoSenai.API.Areas.Administracao.Controllers
{
    [Authorize(Roles = "Administrador")]
    [ApiController]
    [Route("api/[controller]")]
    public class FuncaoController : CrudController<Funcao, FuncaoModel>
    {
        private readonly IBaseCrudService<Funcao> _funcaoService;
        private readonly IMapper _mapper;

        public FuncaoController(IBaseCrudService<Funcao> funcaoService, IMapper mapper)
        {
            _funcaoService = funcaoService;
            _mapper = mapper;
        }

    }
}
