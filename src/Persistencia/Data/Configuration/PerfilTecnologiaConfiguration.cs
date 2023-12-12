using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PerfilTecnologiaConfiguration : IEntityTypeConfiguration<PerfilTecnologia>
{
    public void Configure(EntityTypeBuilder<PerfilTecnologia> builder)
    {

        builder.ToTable("PerfilTecnologia");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdPerfilTecnologia")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.FkPerfilId)
            .HasColumnName("FkPerfilId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Perfiles)
            .WithMany(p => p.PerfilTecnologias)
            .HasForeignKey(p => p.FkPerfilId);
        
        builder.Property(p => p.FkTecnologiaId)
            .HasColumnName("FkTecnologiaId")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(p => p.Tecnologias)
            .WithMany(p => p.PerfilTecnologias)
            .HasForeignKey(p => p.FkTecnologiaId);
        
        
        
        
        
        
        builder.HasData(
            new PerfilTecnologia
            {
                Id = 1,
                FkPerfilId = 1,
                FkTecnologiaId = 1
            },
            new PerfilTecnologia
            {
                Id = 2,
                FkPerfilId = 2,
                FkTecnologiaId = 2
            },
            new PerfilTecnologia
            {
                Id = 3,
                FkPerfilId = 3,
                FkTecnologiaId = 3
            },
            new PerfilTecnologia
            {
                Id = 4,
                FkPerfilId = 1,
                FkTecnologiaId = 4
            },
            new PerfilTecnologia
            {
                Id = 5,
                FkPerfilId = 2,
                FkTecnologiaId = 5
            },
            new PerfilTecnologia
            {
                Id = 6,
                FkPerfilId = 3,
                FkTecnologiaId = 6
            },
            new PerfilTecnologia
            {
                Id = 7,
                FkPerfilId = 1,
                FkTecnologiaId = 7
            },
            new PerfilTecnologia
            {
                Id = 8,
                FkPerfilId = 2,
                FkTecnologiaId = 8
            },
            new PerfilTecnologia
            {
                Id = 9,
                FkPerfilId = 3,
                FkTecnologiaId = 9
            },
            new PerfilTecnologia
            {
                Id = 10,
                FkPerfilId = 1,
                FkTecnologiaId = 10
            }
        );



    }
}
