using Chamados.Models;

namespace Chamados.repositorio
{
    public interface IChamadoRepositorio
    {
        List<ChamadoModel>BuscarTodos();
        ChamadoModel Adicionar(ChamadoModel chamado);
    }
}