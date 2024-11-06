using RunGym.Models;
using RunGym.API.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunGym.Run;
namespace RunGym.API.Repositorios
{
    public class MedicamentosReposity : IMedicamentosReposity
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

        public async Task<Medicamentos> GetMedicamentosById(int id)
        {
            var data = await context.medicamentos.Where(x => x.Id == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Medicamentos> GetMedicamentosByName(string nombre)
        {
            var data = await context.medicamentos.Where(x => x.Nombre_Medicamento == nombre).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> PostMedicamentos(Medicamentos medicamentos)
        {
            await context.medicamentos.AddAsync(medicamentos);
            await context.SaveAsync();
            return true;
        }

        public async Task<bool> PutMedicamentos(Medicamentos medicamentos)
        {
            context.Update(medicamentos);
            await context.SaveAsync();
            return true;

        }

        public async Task<bool> DeleteMedicamentos(Medicamentos medicamentos)
        {
            context.medicamentos.Remove(medicamentos);
            await context.SaveAsync();
            return true;
        }
    }
}
