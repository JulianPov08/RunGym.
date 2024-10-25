using System;
namespace RunGym.Models
{
    public class RutinasEjercicio
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NombreRutina { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }

    }
}