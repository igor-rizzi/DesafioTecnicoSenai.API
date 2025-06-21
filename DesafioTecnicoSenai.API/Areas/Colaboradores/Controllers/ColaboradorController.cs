using AutoMapper;
using DesafioTecnicoSenai.API.Areas.Colaboradores.Models;
using DesafioTecnicoSenai.API.Common;
using DesafioTecnicoSenai.Application.Interfaces.Services;
using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.Domain.Entities.Colaboradores;
using DesafioTecnicoSenai.InfraData.Models.Autenticacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace DesafioTecnicoSenai.API.Areas.Colaboradores.Controllers
{
    [Authorize(Roles = "Administrador")]
    [ApiController]
    [Route("api/[controller]")]
    public class ColaboradorController : CrudController<Colaborador, ColaboradorModel>
    {
        private readonly ICrudService<Colaborador> _colaboradorService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public ColaboradorController(ICrudService<Colaborador> colaborador, 
            IMapper mapper, 
            UserManager<User> userManager)
        {
            _colaboradorService = colaborador;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost("inserir")]
        public override async Task<IActionResult> Inserir(ColaboradorModel model)
        {
            try
            {
                if (!Validar(model))
                {
                    return Json(new { Sucesso = false, Dados = model });
                }

                model.Id = 0;
                var entity = Mapper.Map<Colaborador>(model);

                await CrudService.InsertAndSaveAsync(entity);
                model.Id = entity.Id;

                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    entity.UsuarioId = user.UsuarioAppId;
                }


                return Json(new { Sucesso = true, Dados = model });
            }
            catch (Exception ex)
            {
                if (ex is DBConcurrencyException) throw;

                throw new Exception(string.Format("Houve uma falha ao salvar as alterações!"), ex);
            }
        }

        [HttpPost("inserir-usuario-colaborador")]
        public async Task<IActionResult> InserirUsuarioColaborador(ColaboradorModel model)
        {
            return Ok();
        }
    }
}
