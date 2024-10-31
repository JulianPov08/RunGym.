using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RunGym.Models
{
    public class Metas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string MetaPrincipal { get; set; }
        public string Areas_De_Objetivo { get; set; }
        public string CuerpoActual { get; set; }
        public string CuerpoDeseado { get; set; }
        public string Ultimavez_CuerpoIdeal { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Progreso { get; set; }

    }
}