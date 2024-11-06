using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class UsuariosReposity :IUsuariosReposity
    {
        private readonly RunGymcontext context;

        public UsuariosReposity(RunGymcontext context)
        {
            this.context = context;
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            var data = await context.usuarios.ToListAsync();
            return data;
        }

        public async Task<Usuarios> GetUsuariosById(int id)
        {
            var data = await context.usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Usuarios> GetUsuariosByName(string nombre)
        {
            var data = await context.usuarios.Where(x => x.Nombre == nombre).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostUsuarios(Usuarios usuarios)
        {
            await context.usuarios.AddAsync(usuarios);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutUsuarios(Usuarios usuarios)
        {
            context.Update(usuarios);
            await context.SaveAsync();
            return true;

        }

        public async Task<bool> DeleteUsuarios(Usuarios usuarios)
        {
            context.usuarios.Remove(usuarios);
            await context.SaveAsync();
            return true;
        }
    }
}
