using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EjerciciosController : ControllerBase
    {
        private readonly IEjerciciosReposity _repository;

        public EjerciciosController(IEjerciciosReposity repository)
        {
            _repository = repository;
        }

        [HttpGet("GetEjercicios")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetEjercicios()
        {
            var response = await _repository.GetEjercicios();
            return Ok(response);
        }

        [HttpPost("PostEjercicios")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostEjercicios([FromBody] Ejercicios ejercicios)
        {
            try
            {
                var response = await _repository.PostEjercicios(ejercicios);
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