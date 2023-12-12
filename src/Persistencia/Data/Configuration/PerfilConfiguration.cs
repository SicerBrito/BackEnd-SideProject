using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
{
    public void Configure(EntityTypeBuilder<Perfil> builder)
    {

        builder.ToTable("Perfil");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdPerfil")
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
        
        builder.Property(p => p.Email)
            .HasColumnName("Email")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(p => p.FkSeniorityId)
            .HasColumnName("FkSeniorityId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Senioritys)
            .WithMany(p => p.Perfiles)
            .HasForeignKey(p => p.FkSeniorityId);

        builder.Property(p => p.FkEspecialidadId)
            .HasColumnName("FkEspecialidadId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Especialidades)
            .WithMany(p => p.Perfiles)
            .HasForeignKey(p => p.FkEspecialidadId);

        builder.Property(p => p.FkUbicacionId)
            .HasColumnName("FkUbicacionId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Ciudades)
            .WithMany(p => p.Perfiles)
            .HasForeignKey(p => p.FkUbicacionId);

        builder.Property(p => p.PretensionSalarialUSD)
            .HasColumnName("PretensionSalarialUSD")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.FkNivelInglesId)
            .HasColumnName("FkNivelInglesId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.NivelDeIngles)
            .WithMany(p => p.Perfiles)
            .HasForeignKey(p => p.FkNivelInglesId);

        builder.Property(p => p.FkDisponibilidadId)
            .HasColumnName("FkDisponibilidadId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.DisponibilidadViajes)
            .WithMany(p => p.Perfiles)
            .HasForeignKey(p => p.FkDisponibilidadId);
        
        
        
        
        builder.HasData(
            new Perfil
            {
                Id = 1,
                Nombres = "Nombre1",
                Apellidos = "Apellido1",
                Email = "correo1@example.com",
                FkSeniorityId = 1,
                FkEspecialidadId = 1,
                FkUbicacionId = 1,
                PretensionSalarialUSD = 60000,
                FkNivelInglesId = 1,
                FkDisponibilidadId = 1
            },
            new Perfil
            {
                Id = 2,
                Nombres = "Nombre2",
                Apellidos = "Apellido2",
                Email = "correo2@example.com",
                FkSeniorityId = 2,
                FkEspecialidadId = 2,
                FkUbicacionId = 2,
                PretensionSalarialUSD = 70000,
                FkNivelInglesId = 2,
                FkDisponibilidadId = 2
            },
            new Perfil
            {
                Id = 3,
                Nombres = "Nombre3",
                Apellidos = "Apellido3",
                Email = "correo3@example.com",
                FkSeniorityId = 3,
                FkEspecialidadId = 3,
                FkUbicacionId = 3,
                PretensionSalarialUSD = 80000,
                FkNivelInglesId = 3,
                FkDisponibilidadId = 3
            },
            new Perfil
            {
                Id = 4,
                Nombres = "Nombre4",
                Apellidos = "Apellido4",
                Email = "correo4@example.com",
                FkSeniorityId = 1,
                FkEspecialidadId = 2,
                FkUbicacionId = 1,
                PretensionSalarialUSD = 75000,
                FkNivelInglesId = 2,
                FkDisponibilidadId = 1
            },
            new Perfil
            {
                Id = 5,
                Nombres = "Nombre5",
                Apellidos = "Apellido5",
                Email = "correo5@example.com",
                FkSeniorityId = 2,
                FkEspecialidadId = 1,
                FkUbicacionId = 2,
                PretensionSalarialUSD = 65000,
                FkNivelInglesId = 1,
                FkDisponibilidadId = 2
            }
        );



    }
}
