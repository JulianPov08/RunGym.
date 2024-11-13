using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ComidasController : ControllerBase
    {
        private readonly IComidasReposity _repository;

        public ComidasController(IComidasReposity repository)
        {
            _repository = repository;
        }

        [HttpGet("GetComidas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetComidas()
        {
            var response = await _repository.GetComidas();
            return Ok(response);
        }

        [HttpPost("PostComidas")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostComidas([FromBody] Comidas comidas)
        {
            try
            {
                var response = await _repository.PostComidas(comidas);
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

