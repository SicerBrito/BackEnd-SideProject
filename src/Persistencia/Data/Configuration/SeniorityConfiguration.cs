using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class SeniorityConfiguration : IEntityTypeConfiguration<Seniority>
{
    public void Configure(EntityTypeBuilder<Seniority> builder)
    {

        builder.ToTable("Seniority");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdSeniority")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(5)
            .IsRequired();
        
        
        
        
        
        
        
        
        
        
        builder.HasData(
            new Seniority 
            {
                Id = 1,
                Nombre = "Ssr+" 
            },
            new Seniority 
            {
                Id = 2,
                Nombre = "Jr+" 
            },
            new Seniority 
            {
                Id = 3,
                Nombre = "Mid+" 
            }
        );



    }
}
