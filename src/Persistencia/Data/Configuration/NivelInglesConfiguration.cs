using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class NivelInglesConfiguration : IEntityTypeConfiguration<NivelIngles>
{
    public void Configure(EntityTypeBuilder<NivelIngles> builder)
    {

        builder.ToTable("NivelIngles");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdNivelIngles")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nivel)
            .HasColumnName("Nivel")
            .HasColumnType("varchar")
            .HasMaxLength(20)
            .IsRequired();
        
        
        
        
        
        
        
        
        
        
        builder.HasData(
            new NivelIngles
            {
                Id = 1,
                Nivel = "Básico"
            },
            new NivelIngles
            {
                Id = 2,
                Nivel = "Básico-Intermedio"
            },
            new NivelIngles
            {
                Id = 3,
                Nivel = "Intermedio"
            },
            new NivelIngles
            {
                Id = 4,
                Nivel = "Intermedio-Avanzado"
            },
            new NivelIngles
            {
                Id = 5,
                Nivel = "Avanzado"
            }
        );



    }
}
