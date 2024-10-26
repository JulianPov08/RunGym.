using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IDietaReposity
    {
        Task<List<Dieta>> GetDieta();

        Task<bool> PostDieta(Dieta dieta);
    }
}
