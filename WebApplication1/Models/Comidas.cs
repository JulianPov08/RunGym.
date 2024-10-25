using System;
namespace RunGym.Models
{
    public class Comidas
    {
        public int Id { get; set; }
        public int IdDieta { get; set; }
        public string TipoComida { get; set; }
        public string HoraComida { get; set; }
        public string Descripcion { get; set; }

    }
}
