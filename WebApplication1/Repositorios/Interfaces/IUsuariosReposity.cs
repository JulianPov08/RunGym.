using RunGym.Models;
using System.Threading.Tasks;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IUsuariosReposity
    {
        Task<List<Usuarios>> GetUsuarios();

        Task<Usuarios> GetUsuariosById(int id);

        Task<Usuarios> GetUsuariosByName(string nombre);

        Task<bool> PostUsuarios(Usuarios usuarios);

        Task<bool> PutUsuarios(Usuarios usuarios);

        Task<bool> DeleteUsuarios(Usuarios usuarios);
    }
}
