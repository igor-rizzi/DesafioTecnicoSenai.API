using System.ComponentModel;

namespace DesafioTecnicoSenai.Domain.Entities.Usuarios.Enums
{
    public enum TipoUsuario
    {
        [Description("Administrador")]
        Administrador = 1,

        [Description("Colaborador")]
        Colaborador = 2,

        [Description("Analista Financeiro")]
        AnalistaFinanceiro = 3
    }
}
