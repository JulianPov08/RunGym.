using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class RutinasEjercicioController : ControllerBase
    {
        private readonly IRutinasEjercicioReposity _repository;

        public RutinasEjercicioController(IRutinasEjercicioReposity repository)
        {
            _repository = repository;
        }

        [HttpGet("GetRutinasEjercicio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetUsuarios()
        {
            var response = await _repository.GetRutinasEjercicio();
            return Ok(response);
        }

        [HttpPost("PostRutinasEjercicio")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostRutinasEjercicio([FromBody] RutinasEjercicio rutinasEjercicio)
        {
            try
            {
                var response = await _repository.PostRutinasEjercicio(rutinasEjercicio);
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
        [HttpPut("PutRutinasEjercicio/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> PutRutinasEjercicio(int id, [FromBody] RutinasEjercicio rutinasEjercicio)
        {
            if (id != rutinasEjercicio.Id)
            {
                return BadRequest("El ID de la rutinasEjercicio no coincide.");
            }

            try
            {
                var response = await _repository.PutRutinasEjercicio(rutinasEjercicio);
                if (response)
                    return Ok("Actualizado correctamente");
                else
                    return NotFound("RutinasEjercicio no encontrada");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("DeleteRutinasEjercicio/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> DeleteRutinasEjercicio(RutinasEjercicio rutinasEjercicio)
        {
            try
            {
                var response = await _repository.DeleteRutinasEjercicio(rutinasEjercicio);
                if (response)
                    return NoContent();
                else
                    return NotFound("RutinasEjercicio no encontrada");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}