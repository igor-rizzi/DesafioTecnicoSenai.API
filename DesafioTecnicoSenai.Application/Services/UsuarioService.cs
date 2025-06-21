using DesafioTecnicoSenai.Application.Interfaces.Repositorios.Usuarios;
using DesafioTecnicoSenai.Application.Interfaces.Services;
using DesafioTecnicoSenai.Domain.Entities.Usuarios;

namespace DesafioTecnicoSenai.Application.Services
{
    public class UsuarioService : CrudService<Usuario>, IUsuarioService  
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
