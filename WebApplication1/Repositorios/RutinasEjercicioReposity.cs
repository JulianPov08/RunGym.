using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class RutinasEjercicioReposity
    {
        private readonly RunGymcontext context;

        public RutinasEjercicioReposity(RunGymcontext context)
        {
            this.context = context;
        }

        public async Task<List<RutinasEjercicio>> GetRutinasEjercicios()
        {
            var data = await context.rutinasEjercicio.ToListAsync();
            return data;
        }

        public async Task<bool> PostRutinasEjercicio(RutinasEjercicio rutinasEjercicio)
        {
            await context.rutinasEjercicio.AddAsync(rutinasEjercicio);
            await context.SaveAsync();
            return true;
        }
    }
}
