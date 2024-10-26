using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class MetasReposity
    {
        private readonly RunGymcontext context;

        public MetasReposity(RunGymcontext context)
        {
            this.context = context;
        }

        public async Task<List<Metas>> GetMetas()
        {
            var data = await context.metas.ToListAsync();
            return data;
        }

        public async Task<bool> PostMetas(Metas metas)
        {
            await context.metas.AddAsync(metas);
            await context.SaveAsync();
            return true;
        }
    }
}
