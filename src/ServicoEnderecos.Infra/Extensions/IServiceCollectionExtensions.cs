using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using ServicoEnderecos.Infra.Data;

namespace ServicoEnderecos.Infra.Extensions;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        string connectionString)
    {
        return services.AddDbContext<ApplicationDbContext>(
            options => options
                .UseMySQL(connectionString)
                .UseSnakeCaseNamingConvention());
    }
}