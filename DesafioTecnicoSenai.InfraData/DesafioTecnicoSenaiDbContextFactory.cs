using DesafioTecnicoSenai.InfraData.Common.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DesafioTecnicoSenai.InfraData
{
    public class DesafioTecnicoSenaiDbContextFactory : IDesignTimeDbContextFactory<DesafioTecnicoSenaiDbContext>
    {
        public DesafioTecnicoSenaiDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DesafioTecnicoSenaiDbContext>();
            var connectionString = configuration.GetConnectionString("DesafioTecnicoSenaiDbContext");

            optionsBuilder.UseNpgsql(connectionString);

            return new DesafioTecnicoSenaiDbContext(optionsBuilder.Options);
        }
    }
}
