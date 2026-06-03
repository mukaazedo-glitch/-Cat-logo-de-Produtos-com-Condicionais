using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class ProdutoControllers : Controller
    {
    
        public IActionResult Index()
        {
            
            List<string> produtos = new List<string> { "Teclado Mecânico", "Mouse Gamer", "Monitor 24", "Cabo HDMI", "Headset" };

            
            List<double> precos = new List<double> { 250.00, 89.90, 850.00, 45.00, 199.90 };

            
            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}