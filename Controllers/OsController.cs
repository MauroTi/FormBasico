using Microsoft.AspNetCore.Mvc;
using FormBasico.Models;
using FormBasico.Services;

namespace FormBasico.Controllers
{
    public class OsController : Controller
    {
        private readonly OsService _osService;

        public OsController(OsService osService)
        {
            _osService = osService;
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();   // procura por Views/Os/Form.cshtml
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form(OsModel model)
        {
            if (ModelState.IsValid)
            {
                _osService.CadastrarOs(model);
                ViewBag.Mensagem = "OS cadastrada com sucesso!";
                // Para evitar repost, você pode:
                // return RedirectToAction("Form");
            }

            // Em caso de erro, retorna o model para repovoar o formulário
            return View(model);
        }

        [HttpGet]
        public IActionResult TestarConexao([FromServices] MySqlConnectionService connService)
        {
            var resultado = connService.TestarConexao();
            return Content(resultado);
        }
    }
}
