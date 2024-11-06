using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IDietaReposity
    {
        Task<List<Dieta>> GetDieta();

        Task<Dieta> GetDietaById(int id);

        Task<Dieta> GetDietaByName(string nombre);

        Task<bool> PostDieta(Dieta dieta);

        Task<bool> PutDieta(Dieta dieta);

        Task<bool> DeleteDieta(Dieta dieta);
    }
}
