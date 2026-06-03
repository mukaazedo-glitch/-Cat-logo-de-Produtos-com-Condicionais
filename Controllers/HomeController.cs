using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class HomeController : Controller
    {
        // Passo 1 do exercício: Criar a Action Boletim()
        public IActionResult Boletim()
        {
            // Passo 2: Listas com nomes de disciplinas e notas
            List<string> disciplinas = new List<string> { "Desenvolvimento Web", "Banco de Dados", "Estrutura de Dados", "Engenharia de Software" };
            List<double> notas = new List<double> { 9.5, 6.2, 4.5, 7.8 };

            // Passando para a View via ViewBag
            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}