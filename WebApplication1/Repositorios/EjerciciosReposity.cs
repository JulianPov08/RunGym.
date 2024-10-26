using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class EjerciciosReposity : IEjerciciosReposity
    {
        private readonly RunGymcontext context;

        public EjerciciosReposity(RunGymcontext context)
        {
            this.context = context;
        }

        public async Task<List<Ejercicios>> GetEjercicios()
        {
            var data = await context.ejercicios.ToListAsync();
            return data;
        }

        public async Task<bool> PostEjercicios(Ejercicios ejercicios)
        {
            await context.ejercicios.AddAsync(ejercicios);
            await context.SaveAsync();
            return true;
        }
    }
}
