using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PerfilSolicitudConfiguration : IEntityTypeConfiguration<PerfilSolicitud>
{
    public void Configure(EntityTypeBuilder<PerfilSolicitud> builder)
    {

        builder.ToTable("PerfilSolicitud");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdPerfilSolicitud")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.FkPerfilId)
            .HasColumnName("FkPerfilId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Perfiles)
            .WithMany(p => p.PerfilSolicitudes)
            .HasForeignKey(p => p.FkPerfilId);

        builder.Property(p => p.FkSolicitudId)
            .HasColumnName("FkSolicitudId")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(p => p.Solicitudes)
            .WithMany(p => p.PerfilSolicitudes)
            .HasForeignKey(p => p.FkSolicitudId);
        
        
        
        
        
        
        
        
        builder.HasData(
            new PerfilSolicitud
            {
                Id = 1,
                FkPerfilId = 1,
                FkSolicitudId = 1
            },
            new PerfilSolicitud
            {
                Id = 2,
                FkPerfilId = 2,
                FkSolicitudId = 2
            },
            new PerfilSolicitud
            {
                Id = 3,
                FkPerfilId = 3,
                FkSolicitudId = 3
            },
            new PerfilSolicitud
            {
                Id = 4,
                FkPerfilId = 1,
                FkSolicitudId = 4
            },
            new PerfilSolicitud
            {
                Id = 5,
                FkPerfilId = 2,
                FkSolicitudId = 5
            },
            new PerfilSolicitud
            {
                Id = 6,
                FkPerfilId = 3,
                FkSolicitudId = 6
            },
            new PerfilSolicitud
            {
                Id = 7,
                FkPerfilId = 1,
                FkSolicitudId = 7
            },
            new PerfilSolicitud
            {
                Id = 8,
                FkPerfilId = 2,
                FkSolicitudId = 8
            },
            new PerfilSolicitud
            {
                Id = 9,
                FkPerfilId = 3,
                FkSolicitudId = 9
            },
            new PerfilSolicitud
            {
                Id = 10,
                FkPerfilId = 1,
                FkSolicitudId = 10
            }
        );



    }
}
