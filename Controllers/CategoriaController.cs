using Microsoft.AspNetCore.Mvc;
using UsandoCRUD_Validaciones.Datos;
using UsandoCRUD_Validaciones.Models;

namespace UsandoCRUD_Validaciones.Controllers
{
	public class CategoriaController : Controller
	{
		private readonly ApplicationDbContext _db;

		public CategoriaController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<Categoria> lista = _db.Categorias;
			return View(lista);
		}

		// GET Crear
		public IActionResult Crear()
		{
			return View();
		}

		// POST Crear
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Crear(Categoria categoria)
		{
			if (ModelState.IsValid)
			{
				_db.Categorias.Add(categoria);
				_db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(categoria);
		}

		// GET Editar
		public IActionResult Editar(int? Id)
		{
			if (Id == null || Id == 0)
			{
				return NotFound();
			}
			var obj = _db.Categorias.Find(Id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}

		// POST Editar
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Editar(Categoria categoria)
		{
			if (ModelState.IsValid)
			{
				_db.Categorias.Update(categoria);
				_db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(categoria);
		}

		// GET Eliminar
		public IActionResult Eliminar(int? Id)
		{
			if (Id == null || Id == 0)
			{
				return NotFound();
			}
			var obj = _db.Categorias.Find(Id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}

		// POST Eliminar
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Eliminar(Categoria categoria)
		{
			if (categoria == null)
			{
				return NotFound();
			}
			_db.Categorias.Remove(categoria);
			_db.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
	}
}
