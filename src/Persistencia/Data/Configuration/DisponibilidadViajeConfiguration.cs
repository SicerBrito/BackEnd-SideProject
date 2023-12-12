using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DisponibilidadViajeConfiguration : IEntityTypeConfiguration<DisponibilidadViaje>
{
    public void Configure(EntityTypeBuilder<DisponibilidadViaje> builder)
    {

        builder.ToTable("DisponibilidadViaje");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdDisponibilidadViaje")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Disponibilidad)
            .HasColumnName("Disponibilidad")
            .HasColumnType("varchar")
            .HasMaxLength(5)
            .IsRequired();
        
        
        
        
        
        
        
        
        
        
        builder.HasData(
            new DisponibilidadViaje
            {
                Id = 1,
                Disponibilidad = "Si"
            },
            new DisponibilidadViaje
            {
                Id = 2,
                Disponibilidad = "No"
            }
        );



    }
}
