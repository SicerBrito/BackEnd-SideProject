using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class EspecialidadConfiguration : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {

        builder.ToTable("Especialidad");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdEspecialidad")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(20)
            .IsRequired();
        
        
        
        
        
        
        
        
        
        
        builder.HasData(
            new Especialidad
            {
                Id = 1,
                Nombre = "Especialidad1"
            },
            new Especialidad
            {
                Id = 2,
                Nombre = "Especialidad2"
            },
            new Especialidad
            {
                Id = 3,
                Nombre = "Especialidad3"
            },
            new Especialidad
            {
                Id = 4,
                Nombre = "Especialidad4"
            },
            new Especialidad
            {
                Id = 5,
                Nombre = "Especialidad5"
            },
            new Especialidad
            {
                Id = 6,
                Nombre = "Especialidad6"
            },
            new Especialidad
            {
                Id = 7,
                Nombre = "Especialidad7"
            },
            new Especialidad
            {
                Id = 8,
                Nombre = "Especialidad8"
            },
            new Especialidad
            {
                Id = 9,
                Nombre = "Especialidad9"
            },
            new Especialidad
            {
                Id = 10,
                Nombre = "Especialidad10"
            }
        );



    }
}
