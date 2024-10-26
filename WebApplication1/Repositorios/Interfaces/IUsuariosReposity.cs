using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IUsuariosReposity
    {
        Task<List<Usuarios>> GetUsuarios();

        Task<bool> PostUsuarios(Usuarios usuarios);
    }
}
