using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.Domain.Entities.Usuarios.Enums;

namespace DesafioTecnicoSenai.Domain.Entities.Usuarios
{
    public class Usuario : Entity
    {
        public required string Nome { get; set; }

        public required string Email { get; set; }

        public required string Senha { get; set; }

        public TipoUsuario TipoUsuario { get; set; } = TipoUsuario.Colaborador;
    }
}
