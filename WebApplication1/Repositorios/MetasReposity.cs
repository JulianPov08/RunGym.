using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class MetasReposity : IMetasReposity
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

        public async Task<Metas> GetMetasById(int id)
        {
            var data = await context.metas.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Metas> GetMetasByName(string nombre)
        {
            var data = await context.metas.Where(x => x.MetaPrincipal == nombre).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostMetas(Metas metas)
        {
            await context.metas.AddAsync(metas);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutMetas(Metas metas)
        {
            context.Update(metas);
            await context.SaveAsync();
            return true;

        }

        public async Task<bool> DeleteMetas(Metas metas)
        {
            context.metas.Remove(metas);
            await context.SaveAsync();
            return true;
        }
    }
}
