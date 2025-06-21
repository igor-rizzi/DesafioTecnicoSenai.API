using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Administracao.Models;
using DesafioTecnicoSenai.API.Common;
using DesafioTecnicoSenai.Application;
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
        private readonly ICrudService<Funcao> _funcaoService;
        private readonly IMapper _mapper;

        public FuncaoController(ICrudService<Funcao> funcaoService, IMapper mapper)
        {
            _funcaoService = funcaoService;
            _mapper = mapper;
        }

    }
}
