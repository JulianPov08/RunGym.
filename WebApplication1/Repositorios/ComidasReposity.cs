using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class ComidasReposity : IComidasReposity
    {
        private readonly RunGymcontext context;

        public ComidasReposity(RunGymcontext context)
        {
            this.context = context; 
        }

        public async Task<List<Comidas>> GetComidas()
        {
            var data = await context.comidas.ToListAsync();
            return data;
        }

        public async Task<bool> PostComidas(Comidas comidas)
        {
            await context.comidas.AddAsync(comidas);
            await context.SaveAsync();
            return true;
        }
    }
}
