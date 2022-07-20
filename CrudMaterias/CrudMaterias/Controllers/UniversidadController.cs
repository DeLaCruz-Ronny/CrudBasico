using CrudMaterias.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CrudMaterias.Controllers
{
    public class UniversidadController : Controller
    {
        private readonly MateriasContext context;

        public UniversidadController(MateriasContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Clases.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Clase clase)
        {
            context.Clases.Add(clase);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int IdMateria)
        {

            Clase c = context.Clases.Find(IdMateria);
            return View(c);
        }

        [HttpPost]
        public IActionResult Edit(Clase oClase)
        {
            context.Update(oClase);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int IdMateria)
        {

            Clase c = context.Clases.Find(IdMateria);
            return View(c);
        }

        [HttpPost]
        public IActionResult Delete(Clase oClase)
        {
            context.Remove(oClase);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
