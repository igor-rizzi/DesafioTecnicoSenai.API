using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.Domain.Entities.Colaboradores;
using DesafioTecnicoSenai.Domain.Entities.Usuarios.Enums;
using System.Reflection.Metadata;

namespace DesafioTecnicoSenai.Domain.Entities.Usuarios
{
    public class Usuario : Entity
    {
        public required string Nome { get; set; }

        public required string Email { get; set; }

        public required string Senha { get; set; }

        public TipoUsuario TipoUsuario { get; set; } = TipoUsuario.Colaborador;

        public long? ColaboradorId { get; set; }

        public string UserLoginId { get; set; }

        public Colaborador Colaborador { get; set; }
    }
}
