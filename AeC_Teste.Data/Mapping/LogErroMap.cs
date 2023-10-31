using AeC_Teste.Business.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeC_Teste.Data.Mapping
{
    public class LogErroMap : IEntityTypeConfiguration<LogErro>
    {
        public void Configure(EntityTypeBuilder<LogErro> builder)
        {
            builder.ToTable("LogErro");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.TipoException)
                       .IsRequired()
                       .HasColumnType("varchar(100)");

            builder.Property(e => e.StackTrace)
                       .IsRequired()
                       .HasColumnType("varchar(1000)");

            builder.Property(e => e.MensagemErro)
                       .IsRequired()
                       .HasColumnType("varchar(250)");

            builder.Property(e => e.Endpoint)
                       .IsRequired()
                       .HasColumnType("varchar(100)");

            builder.Property(e => e.DataErro)
                       .IsRequired();
        }
    }
}
