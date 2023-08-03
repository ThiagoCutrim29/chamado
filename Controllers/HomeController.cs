using Chamados.Models;
using Chamados.repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chamados.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChamadoRepositorio _chamadoRepositorio;
        public HomeController(IChamadoRepositorio chamadoRepositorio)
        {
            _chamadoRepositorio = chamadoRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult ChmdAberto()
        {
            List<ChamadoModel> chamados = _chamadoRepositorio.BuscarTodos();

            return View(chamados);
            
        }
        public IActionResult ChmdEncerrado()
        {
            return View();
        }

    
    }
}