using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IMedicamentosReposity
    {
        Task<List<Medicamentos>> GetMedicamentos();

        Task<bool> PostMedicamentos(Medicamentos medicamentos);
    }
}
