using DesafioTecnicoSenai.InfraData.Common.Context;
using DesafioTecnicoSenai.InfraData.Models.Autenticacao;
using DesafioTecnicoSenai.InfraData.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoSenai.Tests.IntegrationTests
{
    public class RoleSeedTests
    {
        private readonly ServiceProvider _serviceProvider;

        public RoleSeedTests()
        {
            var services = new ServiceCollection();
            services.AddLogging();

            services.AddDbContext<DesafioTecnicoSenaiDbContext>(options =>
                options.UseInMemoryDatabase("TestDb"));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DesafioTecnicoSenaiDbContext>()
                .AddDefaultTokenProviders();

            _serviceProvider = services.BuildServiceProvider();
        }

        [Fact]
        public async Task Deve_Criar_Roles_Corretamente()
        {
            using var scope = _serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            await IdentitySeedData.SeedRolesAsync(roleManager);

            Assert.True(await roleManager.RoleExistsAsync("Administrador"));
            Assert.True(await roleManager.RoleExistsAsync("Analista Financeiro"));
            Assert.True(await roleManager.RoleExistsAsync("Colaborador"));
        }
    }
}
