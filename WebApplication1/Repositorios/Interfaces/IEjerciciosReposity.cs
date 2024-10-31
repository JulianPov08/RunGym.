using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces

{
    public interface IEjerciciosReposity
    {
        Task<List<Ejercicios>> GetEjercicios();

        Task<bool> PostEjercicios(Ejercicios ejercicios);

        Task<bool> PutEjercicios(Ejercicios ejercicios);

        Task<bool> DeleteEjercicios(Ejercicios ejercicios);
    }
}
