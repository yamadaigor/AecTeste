using AeC_Teste.Business.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeC_Teste.Data.Mapping
{
    public class PrevisaoTempoCidadeMap : IEntityTypeConfiguration<PrevisaoTempoCidade>
    {
        public void Configure(EntityTypeBuilder<PrevisaoTempoCidade> builder)
        {
            builder.ToTable("PrevisaoTempoCidade");

            builder.HasKey(c => c.Id);

            builder.Property(a => a.IdCidade)
                      .IsRequired();

            builder.Property(a => a.NomeCidade)
                      .IsRequired()
                      .HasColumnType("varchar(200)");

            builder.Property(a => a.Estado)
                      .IsRequired()
                      .HasColumnType("varchar(50)");

            builder.Property(a => a.DataPrevisao)
                       .IsRequired();

            builder.Property(a => a.Condicao)
                      .IsRequired()
                      .HasColumnType("varchar(50)");

            builder.Property(a => a.TemperaturaMinima)
                       .IsRequired();

            builder.Property(a => a.TemperaturaMaxima)
                       .IsRequired();

            builder.Property(a => a.IndiceUV)
                       .IsRequired();

            builder.Property(a => a.DescricaoCondicao)
                      .IsRequired()
                      .HasColumnType("varchar(100)");

            builder.Property(a => a.Data)
                       .IsRequired();
        }
    }
}
