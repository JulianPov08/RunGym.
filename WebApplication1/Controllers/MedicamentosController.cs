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
        [HttpPut("PutMedicamentos/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> PutMedicamentos(int id, [FromBody] Medicamentos medicamentos)
        {
            if (id != medicamentos.Id)
            {
                return BadRequest("El ID de los medicamentos no coincide.");
            }

            try
            {
                var response = await _repository.PutMedicamentos(medicamentos);
                if (response)
                    return Ok("Actualizado correctamente");
                else
                    return NotFound("Medicamentos no encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("DeleteMedicamentos/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> DeleteMedicamentos(Medicamentos medicamentos)
        {
            try
            {
                var response = await _repository.DeleteMedicamentos(medicamentos);
                if (response)
                    return NoContent();
                else
                    return NotFound("Medicamento no encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}