using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RunGym.Models
{
    public class RutinasEjercicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NombreRutina { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }

    }
}