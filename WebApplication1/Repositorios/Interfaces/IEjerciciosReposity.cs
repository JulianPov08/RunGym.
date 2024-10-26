using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces

{
    public interface IEjerciciosReposity
    {
        Task<List<Ejercicios>> GetEjercicios();

        Task<bool> PostEjercicios(Ejercicios ejercicios);
    }
}
