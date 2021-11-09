
using ImportarArquivoXLS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImportarArquivoXLS.Infra.EntityConfig
{   
    public class DadosDaPlanilhaMap : IEntityTypeConfiguration<DadosDaPlanilha>
    {
        public void Configure(EntityTypeBuilder<DadosDaPlanilha> builder)
        {
            builder.ToTable("DadosDaPlanilha");

            builder.HasKey(pg => pg.PagamentoID);

            builder.Property(pg => pg.PagamentoID)
                .ValueGeneratedOnAdd();

            builder.Property(pg => pg.Credor)
                .HasMaxLength(8000)
                .IsRequired();

            builder.Property(pg => pg.NumeroProcesso)
                 .HasMaxLength(8000)
                .IsRequired();

            builder.Property(pg => pg.Finalidade)
                 .HasMaxLength(8000)
                .IsRequired();

            builder.Property(pg => pg.Data)
                .IsRequired();

            builder.Property(pg => pg.Status)
                 .HasMaxLength(8000)
                .IsRequired();

            builder.Property(pg => pg.ValorPago)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(pg => pg.DocumentoCredor)
                 .HasMaxLength(8000)
                .IsRequired();

            builder.Property(pg => pg.Movimentacao)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(pg => pg.DataAtualizacao)
                .IsRequired();

            builder.Property(pg => pg.CpfCnpjCessionario)
                 .HasMaxLength(18)
                .IsRequired();

            builder.Property(pg => pg.Cessionario)
                 .HasMaxLength(500)
                .IsRequired();
        }
    }
}
