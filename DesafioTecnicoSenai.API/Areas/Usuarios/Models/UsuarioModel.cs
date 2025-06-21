using DesafioTecnicoSenai.Application.Interfaces;
using DesafioTecnicoSenai.Domain.Entities.Usuarios.Enums;

namespace DesafioTecnicoSenai.API.Areas.Usuarios.Models
{
    public class UsuarioModel : IModel
    {
        public long Id { get; set; }

        public required string Nome { get; set; }

        public required string Email { get; set; }

        public required string Senha { get; set; }

        public TipoUsuario TipoUsuario { get; set; } = TipoUsuario.Colaborador;
    }
}
