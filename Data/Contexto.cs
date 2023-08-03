using Chamados.Models;
using Microsoft.EntityFrameworkCore;

namespace Chamados.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ChamadoModel> Chamados { get; set; }


    }
}
