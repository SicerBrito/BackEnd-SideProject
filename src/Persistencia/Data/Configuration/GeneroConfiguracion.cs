using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {

        builder.ToTable("Genero");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdGenero")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(70)
            .IsRequired();
        
        
        
        
        
        
        builder.HasData(
            new {
                Id = 1,
                Nombre = "Masculino"
            },
            new {
                Id = 2,
                Nombre = "Femenino"
            },
            new {
                Id = 3,
                Nombre = "Desconocido"
            },
            new {
                Id = 4,
                Nombre = "Helicoptero Apache"
            },
            new {
                Id = 5,
                Nombre = "Prefiero no decirlo"
            },
            new {
                Id = 6,
                Nombre = "LGBTTTIOQ"
            }
        );


    }
}
