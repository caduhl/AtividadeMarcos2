using Microsoft.AspNetCore.Mvc;

namespace web_teste_asp.Controllers
{
    public class Teste : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
