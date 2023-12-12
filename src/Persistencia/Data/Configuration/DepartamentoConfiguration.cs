using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {

        builder.ToTable("Departamento");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdDepartamento")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(p => p.FkPaisId)
            .HasColumnName("FkPaisId")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(p => p.Paises)
            .WithMany(p => p.Departamentos)
            .HasForeignKey(p => p.FkPaisId);
        
        
        
        
        
        
        builder.HasData(
            new Departamento
            {
                Id = 1,
                Nombre = "Departamento1",
                FkPaisId = 1
            },
            new Departamento
            {
                Id = 2,
                Nombre = "Departamento2",
                FkPaisId = 1
            },
            new Departamento
            {
                Id = 3,
                Nombre = "Departamento3",
                FkPaisId = 2
            },
            new Departamento
            {
                Id = 4,
                Nombre = "Departamento4",
                FkPaisId = 2
            },
            new Departamento
            {
                Id = 5,
                Nombre = "Departamento5",
                FkPaisId = 3
            },
            new Departamento
            {
                Id = 6,
                Nombre = "Departamento6",
                FkPaisId = 3
            },
            new Departamento
            {
                Id = 7,
                Nombre = "Departamento7",
                FkPaisId = 4
            },
            new Departamento
            {
                Id = 8,
                Nombre = "Departamento8",
                FkPaisId = 4
            },
            new Departamento
            {
                Id = 9,
                Nombre = "Departamento9",
                FkPaisId = 5
            },
            new Departamento
            {
                Id = 10,
                Nombre = "Departamento10",
                FkPaisId = 5
            }
        );



    }
}
