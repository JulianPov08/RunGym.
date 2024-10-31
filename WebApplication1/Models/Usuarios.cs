using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RunGym.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string FechaRegistro { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string NivelActividad { get; set; }
        public string HorasSueno { get; set; }
        public string ConsumoAgua { get; set; }
        public string PesoDeseado { get; set; }
        public string FechaUltimoPesoIdeal { get; set; }
        public string TipoCuerpo { get; set; }
        public string CuerpoDeseado { get; set; }
        public string ResumenBienestar { get; set; }


    }
}