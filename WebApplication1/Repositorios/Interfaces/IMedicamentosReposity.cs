using RunGym.Models;
namespace RunGym.API.Repositorios.Interfaces
{
    public interface IMedicamentosReposity
    {
        Task<List<Medicamentos>> GetMedicamentos();

        Task<Medicamentos> GetMedicamentosById(int id);

        Task<Medicamentos> GetMedicamentosByName(string nombre);

        Task<bool> PostMedicamentos(Medicamentos medicamentos);

        Task<bool> PutMedicamentos(Medicamentos medicamentos);

        Task<bool> DeleteMedicamentos(Medicamentos medicamentos);
    }
}
