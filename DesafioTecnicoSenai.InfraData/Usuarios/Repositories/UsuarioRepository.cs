using DesafioTecnicoSenai.Application.Interfaces.Repositorios.Usuarios;
using DesafioTecnicoSenai.Domain.Entities.Usuarios;
using DesafioTecnicoSenai.InfraData.Common.Context;
using DesafioTecnicoSenai.InfraData.Common.Repositories;

namespace DesafioTecnicoSenai.InfraData.Usuarios.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DesafioTecnicoSenaiDbContext context) : base(context)
        {
        }
    }
}
