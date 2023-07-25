using Chamados.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chamados.Controllers
{
    public class ChamadoController : Controller
    {
       
        public IActionResult EditChmd()
        {
            return View();
        } public IActionResult ExcluirChmd()
        {
            return View();
        }
    }
}
