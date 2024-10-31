using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ADSOController : ControllerBase
    {
        private readonly IUsuariosReposity _repository;

        public ADSOController(IUsuariosReposity repository)
        {
            _repository = repository;
        }

        [HttpGet("GetUsuarios")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetUsuarios()
        {
            var response = await _repository.GetUsuarios();
            return Ok(response);
        }

        [HttpPost("PostUsuarios")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostUsuarios([FromBody] Usuarios adso)
        {
            try
            {
                var response = await _repository.PostUsuarios(adso);
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
