using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.Domain.Entities.Colaboradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoSenai.Domain.Entities.Administracao
{
    public class Funcao : Entity
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();
    }
}
