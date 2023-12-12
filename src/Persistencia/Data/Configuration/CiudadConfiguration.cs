using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {

        builder.ToTable("Ciudad");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdCiudad")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(p => p.FkDepartamentoId)
            .HasColumnName("FkDepartamentoId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Departamentos)
            .WithMany(p => p.Ciudades)
            .HasForeignKey(p => p.FkDepartamentoId);
        
        
        
        
        
        
        
        
        builder.HasData(
            new Ciudad
            {
                Id = 1,
                Nombre = "Ciudad1",
                FkDepartamentoId = 1
            },
            new Ciudad
            {
                Id = 2,
                Nombre = "Ciudad2",
                FkDepartamentoId = 1
            },
            new Ciudad
            {
                Id = 3,
                Nombre = "Ciudad3",
                FkDepartamentoId = 2
            },
            new Ciudad
            {
                Id = 4,
                Nombre = "Ciudad4",
                FkDepartamentoId = 2
            },
            new Ciudad
            {
                Id = 5,
                Nombre = "Ciudad5",
                FkDepartamentoId = 3
            },
            new Ciudad
            {
                Id = 6,
                Nombre = "Ciudad6",
                FkDepartamentoId = 3
            },
            new Ciudad
            {
                Id = 7,
                Nombre = "Ciudad7",
                FkDepartamentoId = 4
            },
            new Ciudad
            {
                Id = 8,
                Nombre = "Ciudad8",
                FkDepartamentoId = 4
            },
            new Ciudad
            {
                Id = 9,
                Nombre = "Ciudad9",
                FkDepartamentoId = 5
            },
            new Ciudad
            {
                Id = 10,
                Nombre = "Ciudad10",
                FkDepartamentoId = 5
            }
        );


    }
}
