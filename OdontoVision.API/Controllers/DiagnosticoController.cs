using Microsoft.AspNetCore.Mvc;
using OdontoVision.Application.ViewModels;

namespace OdontoVision.Controllers
{
    public class DiagnosticoController : Controller
    {
        public IActionResult Index()
        {
            var diagnosticos = new List<DiagnosticoViewModel>
            {
                new DiagnosticoViewModel { Id = 1, Descricao = "Cárie" },
                new DiagnosticoViewModel { Id = 2, Descricao = "Gengivite" }
            };
            return View(diagnosticos);
        }

        public IActionResult Details(int id)
        {
            var diagnostico = new DiagnosticoViewModel { Id = id, Descricao = "Cárie" };
            return View(diagnostico);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiagnosticoViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var diagnostico = new DiagnosticoViewModel { Id = id, Descricao = "Cárie" };
            return View(diagnostico);
        }

        [HttpPost]
        public IActionResult Edit(DiagnosticoViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var diagnostico = new DiagnosticoViewModel { Id = id, Descricao = "Cárie" };
            return View(diagnostico);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
