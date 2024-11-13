using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MetasController : ControllerBase
    {
        private readonly IMetasReposity _repository;

        public MetasController(IMetasReposity repository)
        {
            _repository = repository;
        }

        [HttpGet("GetMetas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetMetas()
        {
            var response = await _repository.GetMetas();
            return Ok(response);
        }

        [HttpPost("PostMetas")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostMetas([FromBody] Metas metas)
        {
            try
            {
                var response = await _repository.PostMetas(metas);
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