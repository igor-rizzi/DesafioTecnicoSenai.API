using DesafioTecnicoSenai.API.Common;

namespace DesafioTecnicoSenai.API.Configuration
{
    public static class MiddlewaresConfiguration
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
