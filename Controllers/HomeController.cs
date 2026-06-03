using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Boletim()
        {
            
            List<string> disciplinas = new List<string> { "Desenvolvimento Web", "Banco de Dados", "Estrutura de Dados", "Engenharia de Software" };
            List<double> notas = new List<double> { 9.5, 6.2, 4.5, 7.8 };

            
            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}