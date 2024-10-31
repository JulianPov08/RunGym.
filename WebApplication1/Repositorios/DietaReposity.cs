using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class DietaReposity : IDietaReposity
    {
        private readonly RunGymcontext context;

        public DietaReposity(RunGymcontext context)
        {
            this.context = context;
        }

        public async Task<List<Dieta>> GetDieta()
        {
            var data = await context.dieta.ToListAsync();
            return data;
        }

        public async Task<bool> PostDieta(Dieta dieta)
        {
            await context.dieta.AddAsync(dieta);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutDieta(Dieta dieta)
        {
            context.Update(dieta);
            await context.SaveAsync();
            return true;

        }

        public async Task<bool> DeleteDieta(Dieta dieta)
        {
            context.dieta.Remove(dieta);
            await context.SaveAsync();
            return true;
        }
    }
}
