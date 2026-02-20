using System.ComponentModel.DataAnnotations;
namespace RecetArreAPI2.DTOs.Categorias
{
   
        public class IngredienteDto
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = default!;
            public string Unidad { get; set; } = default!;
            public string Descripcion { get; set; } = default!;
        public DateTime CreadoUtc { get; set; }
        }

        public class IngredienteCreacionDto
        {
            public string Nombre { get; set; } = default!;
            public string Unidad { get; set; } = default!;
        public string Descripcion { get; set; } = default!;
    }

        public class IngredienteModificacionDto
        {
            public string Nombre { get; set; } = default!;
            public string Unidad { get; set; } = default!;
        public string Descripcion { get; set; } = default!;
    }
    }


