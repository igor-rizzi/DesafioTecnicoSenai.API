using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.Domain.Entities.Colaboradores;

namespace DesafioTecnicoSenai.Domain.Entities.Administracao
{
    public class Cargo : Entity
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();
    }
}
