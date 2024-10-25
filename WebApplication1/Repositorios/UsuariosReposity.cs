﻿using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class UsuariosReposity
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

        public async Task<bool> PostUsuarios(Usuarios usuarios)
        {
            await context.usuarios.AddAsync(usuarios);
            await context.SaveAsync();
            return true;
        }
    }
}
