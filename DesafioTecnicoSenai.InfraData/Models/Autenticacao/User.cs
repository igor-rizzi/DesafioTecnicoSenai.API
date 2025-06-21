using Microsoft.AspNetCore.Identity;

namespace DesafioTecnicoSenai.InfraData.Models.Autenticacao
{
    public class User : IdentityUser
    {
        public bool Ativo { get; set; }
    }
}
