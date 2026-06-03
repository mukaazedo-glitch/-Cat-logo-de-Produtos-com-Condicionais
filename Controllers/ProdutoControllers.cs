using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class ProdutoController : Controller
    {
        // Passo 1 e 2 do exercício: Método Index()
        public IActionResult Index()
        {
            // Passo 2: Criando a lista com 5 nomes de produtos
            List<string> produtos = new List<string> { "Teclado Mecânico", "Mouse Gamer", "Monitor 24", "Cabo HDMI", "Headset" };

            // Passo 3: Criando a lista com os preços correspondentes
            List<double> precos = new List<double> { 250.00, 89.90, 850.00, 45.00, 199.90 };

            // Passo 4: Passando ambas as listas via ViewBag
            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}