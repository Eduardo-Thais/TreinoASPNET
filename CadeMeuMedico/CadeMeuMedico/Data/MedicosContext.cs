using CadeMeuMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace CadeMeuMedico.Data
{
    public class MedicosContext : DbContext
    {
        public MedicosContext(DbContextOptions<MedicosContext> options) : base(options)
        {

        }

        public DbSet<MedicoModel> Medico { get; set; }
        public DbSet<CidadeModel> Cidade { get; set; }
        public DbSet<EspecialidadeModel> Especialidade { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
