using System.ComponentModel.DataAnnotations;

namespace UsandoCRUD_Validaciones.Models
{
	public class Categoria
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "El Nombre de categoría es obligatorio")]
		public string NombreCategoria { get; set; }

		[Required(ErrorMessage = "El Orden es obligatorio")]
		[Range(1, int.MaxValue, ErrorMessage = "El orden debe ser mayor a cero")]
		public int Orden { get; set; }

		[Required(ErrorMessage = "La descripción es obligatoria")]
		public string Descripcion { get; set; }
	}
}

