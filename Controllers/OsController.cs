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
            return View("Form");
        }

        [HttpPost]
        public IActionResult Form(OsModel model)
        {
            if (ModelState.IsValid)
            {
                _osService.CadastrarOs(model);
                ViewBag.Mensagem = "OS cadastrada com sucesso!";
            }

            return View();
        }

        [HttpGet]
        public IActionResult TestarConexao([FromServices] MySqlConnectionService connService)
        {
            var resultado = connService.TestarConexao();
            return Content(resultado);
        }
    }
}