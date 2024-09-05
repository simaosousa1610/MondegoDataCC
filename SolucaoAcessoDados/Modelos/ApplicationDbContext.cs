using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Modelos
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
    
        }


        public DbSet<Aplicacao> Aplicacoes { get; set; }
        public DbSet<Operadores> Operadores { get; set; }
        public DbSet<Acesso> Acesso { get; set; }
        public DbSet<RegistoHoras> RegistosHoras { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Acao> Acao { get; set; }
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }
    }
}
