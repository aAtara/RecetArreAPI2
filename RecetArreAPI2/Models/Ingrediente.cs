using System.ComponentModel.DataAnnotations;

namespace RecetArreAPI2.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Unidad { get; set; } = string.Empty; // para kg, litros, piezas

        [Range(0, double.MaxValue, ErrorMessage = "Ingresa una cantidad valida")]

        public String Descripcion { get; set; } = string.Empty;


    }
}

