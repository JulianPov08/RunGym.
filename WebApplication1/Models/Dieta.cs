using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RunGym.Models
{
    public class Dieta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string TipoDieta { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public decimal CaloriasDiarias { get; set; }
        public string Macronutrientes { get; set; }
        public string Descripcion { get; set; }

    }
}