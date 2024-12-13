﻿using RunGym.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RunGym.Models;
using Microsoft.AspNetCore.Authorization;

namespace RunGym.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
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
        [HttpPut("PutEjercicios/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> PutEjercicios(int id, [FromBody] Ejercicios ejercicios)
        {
            if (id != ejercicios.Id)
            {
                return BadRequest("El ID de los ejercicios no coincide.");
            }

            try
            {
                var response = await _repository.PutEjercicios(ejercicios);
                if (response)
                    return Ok("Actualizado correctamente");
                else
                    return NotFound("Ejercicio no encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("DeleteEjercicios/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> DeleteEjercicios(Ejercicios ejercicios)
        {
            try
            {
                var response = await _repository.DeleteEjercicios(ejercicios);
                if (response)
                    return NoContent();
                else
                    return NotFound("Ejercicio no encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}