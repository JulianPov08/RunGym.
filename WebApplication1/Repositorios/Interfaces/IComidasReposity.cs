using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IComidasReposity
    {
        Task<List<Comidas>> GetComidas();
        Task<bool> PostComidas(Comidas comidas);
    }
}
