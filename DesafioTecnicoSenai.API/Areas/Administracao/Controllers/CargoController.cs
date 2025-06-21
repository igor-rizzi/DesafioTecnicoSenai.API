using DesafioTecnicoSenai.API.Areas.Administracao.Models;
using DesafioTecnicoSenai.API.Common;
using DesafioTecnicoSenai.Domain.Entities.Administracao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnicoSenai.API.Areas.Administracao.Controllers
{
    [Authorize(Roles = "Administrador")]
    [ApiController]
    [Route("api/[controller]")]
    public class CargoController : CrudController<Cargo, CargoModel>
    {
        public CargoController()
        {
            
        }
    }
}
