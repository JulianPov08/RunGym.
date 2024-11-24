﻿using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IRutinasEjercicioReposity
    {
        Task<List<RutinasEjercicio>> GetRutinasEjercicio();

        Task<RutinasEjercicio> GetRutinasEjercicioById(int id);

        Task<RutinasEjercicio> GetRutinasEjercicioByName(string nombre);

        Task<bool> PostRutinasEjercicio(RutinasEjercicio rutinasEjercicio);

        Task<bool> PutRutinasEjercicio(RutinasEjercicio rutinasEjercicio);

        Task<bool> DeleteRutinasEjercicio(RutinasEjercicio rutinasEjercicio);
    }
}
