using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {

        builder.ToTable("Pais");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdPais")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
        
        
        
        
        
        
        
        
        
        builder.HasData(
            new Pais
            {
                Id = 1,
                Nombre = "Pais1"
            },
            new Pais
            {
                Id = 2,
                Nombre = "Pais2"
            },
            new Pais
            {
                Id = 3,
                Nombre = "Pais3"
            },
            new Pais
            {
                Id = 4,
                Nombre = "Pais4"
            },
            new Pais
            {
                Id = 5,
                Nombre = "Pais5"
            },
            new Pais
            {
                Id = 6,
                Nombre = "Pais6"
            },
            new Pais
            {
                Id = 7,
                Nombre = "Pais7"
            },
            new Pais
            {
                Id = 8,
                Nombre = "Pais8"
            },
            new Pais
            {
                Id = 9,
                Nombre = "Pais9"
            },
            new Pais
            {
                Id = 10,
                Nombre = "Pais10"
            }
        );



    }
}
