using System.ComponentModel.DataAnnotations;

namespace Chamados.Models
{

    public class ChamadoModel
    {
        public int id { get; set; }

        public string titulo { get; set; }

        public string descricao { get; set; }

        public string? status { get; set; }
    }
}
