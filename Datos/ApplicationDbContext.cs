using Microsoft.EntityFrameworkCore;
using UsandoCRUD_Validaciones.Models;

namespace UsandoCRUD_Validaciones.Datos
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Categoria> Categorias { get; set; }
	}
}
