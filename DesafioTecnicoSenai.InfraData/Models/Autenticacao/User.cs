using DesafioTecnicoSenai.Domain.Entities.Usuarios;
using Microsoft.AspNetCore.Identity;

namespace DesafioTecnicoSenai.InfraData.Models.Autenticacao
{
    public class User : IdentityUser
    {
        public long? UsuarioAppId { get; set; }

        public bool Ativo { get; set; }

        public Usuario UsuarioApp { get; set; }
    }
}
