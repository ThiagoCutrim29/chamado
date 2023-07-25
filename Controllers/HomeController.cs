using Chamados.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chamados.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult ChmdAberto()
        {
            return View();
        }
        public IActionResult ChmdEncerrado()
        {
            return View();
        }

    
    }
}