using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class MedicamentosReposity
    {
        private readonly RunGymcontext context;

        public MedicamentosReposity(RunGymcontext context)
        {
            this.context = context;
        }

        public async Task<List<Medicamentos>> GetMedicamentos()
        {
            var data = await context.medicamentos.ToListAsync();
            return data;
        }

        public async Task<bool> PostMedicamentos(Medicamentos medicamentos)
        {
            await context.medicamentos.AddAsync(medicamentos);
            await context.SaveAsync();
            return true;
        }
    }
}
