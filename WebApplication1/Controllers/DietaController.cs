using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DietaController : ControllerBase
    {
        private readonly IDietaReposity _repository;

        public DietaController(IDietaReposity repository)
        {
            _repository = repository;
        }

        [HttpGet("GetDieta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetDieta()
        {
            var response = await _repository.GetDieta();
            return Ok(response);
        }

        [HttpPost("PostDieta")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostDieta([FromBody] Dieta dieta)
        {
            try
            {
                var response = await _repository.PostDieta(dieta);
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
