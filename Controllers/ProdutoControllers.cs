using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class ProdutoControllers : Controller
    {
        // Passo 1: Criar o método Index()
        public IActionResult Index()
        {
            // Passo 2: Lista com 5 nomes de produtos
            List<string> produtos = new List<string> { "Teclado Mecânico", "Mouse Gamer", "Monitor 24", "Cabo HDMI", "Headset" };

            // Passo 3: Lista com os preços correspondentes
            List<double> precos = new List<double> { 250.00, 89.90, 850.00, 45.00, 199.90 };

            // Passo 4: Passando ambas as listas via ViewBag (a nossa "bandeja")
            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}