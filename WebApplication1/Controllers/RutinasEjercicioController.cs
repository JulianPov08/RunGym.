using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
    }
}