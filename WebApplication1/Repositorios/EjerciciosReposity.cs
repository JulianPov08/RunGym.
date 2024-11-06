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

        public async Task<Ejercicios> GetEjerciciosById(int id)
        {
            var data = await context.ejercicios.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Ejercicios> GetEjerciciosByName(string nombre)
        {
            var data = await context.ejercicios.Where(x => x.Nombre_Ejercicio == nombre).FirstOrDefaultAsync();
            return data;
        }
        public async Task<bool> PostEjercicios(Ejercicios ejercicios)
        {
            await context.ejercicios.AddAsync(ejercicios);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutEjercicios(Ejercicios ejercicios)
        {
            context.Update(ejercicios);
            await context.SaveAsync();
            return true;

        }

        public async Task<bool> DeleteEjercicios(Ejercicios ejercicios)
        {
            context.ejercicios.Remove(ejercicios);
            await context.SaveAsync();
            return true;
        }
    }
}
