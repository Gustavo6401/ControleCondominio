using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Infra.Data.Contexto
{
    public class PortariaContext : DbContext
    {
        // Colocar no meu site de vagas de emprego algumas propriedades não listáveis no banco de dados.
        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Predio> Predio { get; set; }
        public DbSet<Morador> Morador { get; set; }
        public DbSet<Apartamento> Apartamento { get; set; }
        public DbSet<Visitante> Visitante { get; set; }
        public DbSet<Garagem> Garagem { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<PrestadorSevicos> PrestadorServico { get; set; }
        public DbSet<Sindico> Sindico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<RecuperacaoSenha> RecuperacaoSenha { get; set; }
        public DbSet<Visita> Visita { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Portaria;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Condominio>().ToTable("Condominio");
            builder.Entity<Predio>().ToTable("Predio");
            builder.Entity<Morador>().ToTable("Morador");
            builder.Entity<Apartamento>().ToTable("Apartamento");
            builder.Entity<Visitante>().ToTable("Visitante");
            builder.Entity<Garagem>().ToTable("Garagem");
            builder.Entity<Veiculo>().ToTable("Veiculo");
            builder.Entity<PrestadorSevicos>().ToTable("PrestadorServicos");
            builder.Entity<Sindico>().ToTable("Sindico");
            builder.Entity<Usuario>().ToTable("Usuario");
            builder.Entity<RecuperacaoSenha>().ToTable("RecuperacaoSenha");
            builder.Entity<Visita>().ToTable("Visita");
        }
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
