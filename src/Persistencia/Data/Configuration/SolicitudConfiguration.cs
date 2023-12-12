using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class SolicitudConfiguration : IEntityTypeConfiguration<Solicitud>
{
    public void Configure(EntityTypeBuilder<Solicitud> builder)
    {

        builder.ToTable("Solicitud");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdSolicitud")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombres)
            .HasColumnName("Nombres")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Apellidos)
            .HasColumnName("Apellidos")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(p => p.Empresa)
            .HasColumnName("Empresa")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Email)
            .HasColumnName("Email")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(p => p.Telefono)
            .HasColumnName("Telefono")
            .HasColumnType("double")
            .IsRequired();
        
        
        
        
        
        
        builder.HasData(
            new Solicitud
            {
                Id = 1,
                Nombres = "Nombre1",
                Apellidos = "Apellido1",
                Empresa = "Empresa1",
                Email = "correo1@example.com",
                Telefono = 1234567890
            },
            new Solicitud
            {
                Id = 2,
                Nombres = "Nombre2",
                Apellidos = "Apellido2",
                Empresa = "Empresa2",
                Email = "correo2@example.com",
                Telefono = 2345678901
            },
            new Solicitud
            {
                Id = 3,
                Nombres = "Nombre3",
                Apellidos = "Apellido3",
                Empresa = "Empresa3",
                Email = "correo3@example.com",
                Telefono = 3456789012
            },
            new Solicitud
            {
                Id = 4,
                Nombres = "Nombre4",
                Apellidos = "Apellido4",
                Empresa = "Empresa4",
                Email = "correo4@example.com",
                Telefono = 4567890123
            },
            new Solicitud
            {
                Id = 5,
                Nombres = "Nombre5",
                Apellidos = "Apellido5",
                Empresa = "Empresa5",
                Email = "correo5@example.com",
                Telefono = 5678901234
            },
            new Solicitud
            {
                Id = 6,
                Nombres = "Nombre6",
                Apellidos = "Apellido6",
                Empresa = "Empresa6",
                Email = "correo6@example.com",
                Telefono = 6789012345
            },
            new Solicitud
            {
                Id = 7,
                Nombres = "Nombre7",
                Apellidos = "Apellido7",
                Empresa = "Empresa7",
                Email = "correo7@example.com",
                Telefono = 7890123456
            },
            new Solicitud
            {
                Id = 8,
                Nombres = "Nombre8",
                Apellidos = "Apellido8",
                Empresa = "Empresa8",
                Email = "correo8@example.com",
                Telefono = 8901234567
            },
            new Solicitud
            {
                Id = 9,
                Nombres = "Nombre9",
                Apellidos = "Apellido9",
                Empresa = "Empresa9",
                Email = "correo9@example.com",
                Telefono = 9012345678
            },
            new Solicitud
            {
                Id = 10,
                Nombres = "Nombre10",
                Apellidos = "Apellido10",
                Empresa = "Empresa10",
                Email = "correo10@example.com",
                Telefono = 1234567890
            }
        );



    }
}
