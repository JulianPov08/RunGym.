﻿using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IMetasReposity
    {
        Task<List<Metas>> GetMetas();

        Task<bool> PostMetas(Metas metas);

        Task<bool> PutMetas(Metas metas);

        Task<bool> DeleteMetas(Metas metas);

    }
}
