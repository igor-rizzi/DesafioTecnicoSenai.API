using DesafioTecnicoSenai.InfraData.Models.Autenticacao;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DesafioTecnicoSenai.InfraData.Common.Context
{
    public class DesafioTecnicoSenaiDbContext : IdentityDbContext<User>
    {
        public DesafioTecnicoSenaiDbContext(DbContextOptions<DesafioTecnicoSenaiDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
