using System.ComponentModel.DataAnnotations;

namespace Registro.Model
{
    public class Ocupaciones
    {

        [Key]
        public int OcupacionId { get; set; }
        public string? Descripcion { get; set; }
        public double Salario  { get; set; }
    }
}
