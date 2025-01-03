﻿using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class RutinasEjercicioReposity : IRutinasEjercicioReposity
    {
        private readonly RunGymcontext context;

        public RutinasEjercicioReposity(RunGymcontext context)
        {
            this.context = context;
        }

        public async Task<List<RutinasEjercicio>> GetRutinasEjercicio()
        {
            var data = await context.rutinasEjercicio.ToListAsync();
            return data;
        }

        public async Task<RutinasEjercicio> GetRutinasEjercicioById(int id)
        {
            var data = await context.rutinasEjercicio.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<RutinasEjercicio> GetRutinasEjercicioByName(string nombre)
        {
            var data = await context.rutinasEjercicio.Where(x => x.NombreRutina == nombre).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostRutinasEjercicio(RutinasEjercicio rutinasEjercicio)
        {
            await context.rutinasEjercicio.AddAsync(rutinasEjercicio);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutRutinasEjercicio(RutinasEjercicio rutinasEjercicio)
        {
            context.Update(rutinasEjercicio);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteRutinasEjercicio(RutinasEjercicio rutinasEjercicio)
        {
            context.rutinasEjercicio.Remove(rutinasEjercicio);
            await context.SaveAsync();
            return true;
        }

        
    }
}
