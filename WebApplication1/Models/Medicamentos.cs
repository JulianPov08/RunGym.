using System;
namespace RunGym.Models
{
    public class Medicamentos
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre_Medicamento { get; set; }
        public string Cantidad { get; set; }
        public string Unidad_Medida { get; set; }
        public string Descripcion { get; set; }

    }
}
