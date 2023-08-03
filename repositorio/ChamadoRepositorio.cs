using Chamados.Data;
using Chamados.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chamados.repositorio
{


    public class ChamadoRepositorio : IChamadoRepositorio
    {
        private readonly Contexto _contexto;
        public ChamadoRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<ChamadoModel> BuscarTodos()
        {
            return _contexto.Chamados.ToList();
        }
       
        public ChamadoModel Adicionar(ChamadoModel chamado)
        {
            _contexto.Chamados.Add(chamado);
            _contexto.SaveChanges();
            return chamado;
        }

       
    }


}