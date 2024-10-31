using RunGym.API.Repositorios;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RunGym.API
{
    public static class DependencyInjectionService 
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration _configuration)
        {
            string connectionString = "";
            connectionString = _configuration["ConnectionStrings:SQLConnectionStrings"];

            services.AddDbContext<DatabaseService>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUsuariosReposity, UsuariosReposity>();


            return services;
        }
    }
}
