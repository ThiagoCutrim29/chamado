using Chamados.Models;
using Chamados.repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chamados.Controllers
{
    public class ChamadoController : Controller
    {
        private readonly IChamadoRepositorio _chamadoRepositorio;
        public ChamadoController(IChamadoRepositorio chamadoRepositorio)
        {
            _chamadoRepositorio= chamadoRepositorio;
        }
        public IActionResult EditChmd()
        {
            return View();
        } public IActionResult ExcluirChmd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ChamadoModel chamado) 
        { 
            _chamadoRepositorio.Adicionar(chamado);
            return RedirectToAction("Index","home");
        }

      
    }
}
