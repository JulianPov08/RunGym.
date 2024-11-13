using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicamentosController : ControllerBase
    {
        private readonly IMedicamentosReposity _repository;

        public MedicamentosController(IMedicamentosReposity repository)
        {
            _repository = repository;
        }

        [HttpGet("GetMedicamentos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetMedicamentos()
        {
            var response = await _repository.GetMedicamentos();
            return Ok(response);
        }

        [HttpPost("PostMedicamentos")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostMedicamentos([FromBody] Medicamentos medicamentos)
        {
            try
            {
                var response = await _repository.PostMedicamentos(medicamentos);
                if (response == true)
                    return Ok("Insertado correctamente");
                else
                    return BadRequest(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}