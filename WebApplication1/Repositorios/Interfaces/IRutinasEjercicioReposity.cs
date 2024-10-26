﻿using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IRutinasEjercicioReposity
    {
        Task<List<RutinasEjercicio>> GetRutinasEjercicio();

        Task<bool> PostRutinasEjercicio(RutinasEjercicio rutinasEjercicio);
    }
}