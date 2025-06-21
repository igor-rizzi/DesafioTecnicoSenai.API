using DesafioTecnicoSenai.API.Areas.Autenticacao.Models;
using DesafioTecnicoSenai.API.Areas.Usuarios.Models;
using DesafioTecnicoSenai.API.Common;
using DesafioTecnicoSenai.Domain.Entities.Usuarios;
using DesafioTecnicoSenai.InfraData.Models.Autenticacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace DesafioTecnicoSenai.API.Areas.Usuarios.Controllers
{
    [Authorize(Roles = "Administrador")]
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : 
        CrudController<Usuario, UsuarioModel>
    {
        private readonly UserManager<User> _userManager;

        public UsuarioController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("criar-usuario")]
        public async Task<IActionResult> CriarUsuario(UsuarioModel model)
        {
            var userExists = await _userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
                return BadRequest("Usuário já existe!");

            var user = new User
            {
                Email = model.Email,
                UserName = model.Nome,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = _userManager.PasswordHasher.HashPassword(null, model.Senha)
            };

            var result = await _userManager.CreateAsync(user);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            await _userManager.AddToRoleAsync(user, model.TipoUsuario.GetDisplayName());

            return Ok("Usuário registrado com sucesso!");
        }
    }
}
