﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Moq;

namespace DesafioTecnicoSenai.Tests.Mocks
{
    public static class IdentityMocks
    {
        public static Mock<UserManager<TUser>> MockUserManager<TUser>() where TUser : class
        {
            var store = new Mock<IUserStore<TUser>>();
            return new Mock<UserManager<TUser>>(store.Object, null, null, null, null, null, null, null, null);
        }

        public static Mock<RoleManager<TRole>> MockRoleManager<TRole>() where TRole : class
        {
            var store = new Mock<IRoleStore<TRole>>();
            var logger = new LoggerFactory().CreateLogger<RoleManager<TRole>>();
            return new Mock<RoleManager<TRole>>(store.Object, null, null, null, logger);
        }
    }
}
