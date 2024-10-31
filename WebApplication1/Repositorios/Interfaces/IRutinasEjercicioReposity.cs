using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IRutinasEjercicioReposity
    {
        Task<List<RutinasEjercicio>> GetRutinasEjercicio();

        Task<bool> PostRutinasEjercicio(RutinasEjercicio rutinasEjercicio);

        Task<bool> PutRutinasEjercicio(RutinasEjercicio rutinasEjercicio);

        Task<bool> DeleteRutinasEjercicios(RutinasEjercicio rutinasEjercicio);
    }
}
