using AeC_Teste.Business.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeC_Teste.Data.Mapping
{
    public class PrevisaoTempoAeroportoMap : IEntityTypeConfiguration<PrevisaoTempoAeroporto>
    {
        public void Configure(EntityTypeBuilder<PrevisaoTempoAeroporto> builder)
        {
            builder.ToTable("PrevisaoTempoAeroporto");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.CodigoIcao)
                      .IsRequired()
                      .HasColumnType("varchar(10)");

            builder.Property(a => a.AtualizadoEm)
                      .IsRequired()
                      .HasColumnType("varchar(100)");

            builder.Property(a => a.PressaoAtmosferica)
                       .IsRequired();

            builder.Property(a => a.Visibilidade)
                       .IsRequired()
                       .HasColumnType("varchar(100)");

            builder.Property(a => a.Vento)
                      .IsRequired();

            builder.Property(a => a.DirecaoVento)
                      .IsRequired();

            builder.Property(a => a.Umidade)
                      .IsRequired();

            builder.Property(a => a.Condicao)
                      .IsRequired()
                      .HasColumnType("varchar(20)");

            builder.Property(a => a.CondicaoDescricao)
                      .IsRequired()
                      .HasColumnType("varchar(100)");

            builder.Property(a => a.Temperatura)
                      .IsRequired();

            builder.Property(a => a.Data)
                      .IsRequired();

        }
    }
}
