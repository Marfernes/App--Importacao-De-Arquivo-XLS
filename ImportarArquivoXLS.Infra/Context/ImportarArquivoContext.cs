using ImportarArquivoXLS.Domain;
using ImportarArquivoXLS.Infra.EntityConfig;
using Microsoft.EntityFrameworkCore;


namespace ImportarArquivoXLS.Infra
{
    public class ImportarArquivoContext : DbContext
    {
        public ImportarArquivoContext(DbContextOptions<ImportarArquivoContext> options) : base(options)
        {
           
        }
        public DbSet<DadosDaPlanilha> DadosDaPlanilha { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DadosDaPlanilhaMap());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;DataBase=BancoImportarArquivoXLS;Integrated Security=True");
        }
    }
}
