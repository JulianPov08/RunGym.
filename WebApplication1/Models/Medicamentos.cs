using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RunGym.Models
{
    public class Medicamentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre_Medicamento { get; set; }
        public string Cantidad { get; set; }
        public string Unidad_Medida { get; set; }
        public string Descripcion { get; set; }

    }
}
