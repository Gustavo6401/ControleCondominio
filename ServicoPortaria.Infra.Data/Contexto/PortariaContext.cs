using Microsoft.EntityFrameworkCore;
using ServicoPortaria.Domain.Enttities;

namespace ServicoPortaria.Infra.Data.Contexto
{
    public class PortariaContext : DbContext
    {
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseMySql(@"Server=localhost;Database=Portaria;Uid=root;Psw=0123456789abcdef");
        }
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
