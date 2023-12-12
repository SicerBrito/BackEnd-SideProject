using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TecnologiaConfiguration : IEntityTypeConfiguration<Tecnologia>
{
    public void Configure(EntityTypeBuilder<Tecnologia> builder)
    {

        builder.ToTable("Tecnologia");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdTecnologia")
        .HasColumnType("int")
        .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(30)
            .IsRequired();
        
        
        
        
        
        
        
        
        
        
        builder.HasData(
            new Tecnologia
            {
                Id = 1,
                Nombre = "Java"
            },
            new Tecnologia
            {
                Id = 2,
                Nombre = "JavaScript"
            },
            new Tecnologia
            {
                Id = 3,
                Nombre = "Python"
            },
            new Tecnologia
            {
                Id = 4,
                Nombre = "C#"
            },
            new Tecnologia
            {
                Id = 5,
                Nombre = "PHP"
            },
            new Tecnologia
            {
                Id = 6,
                Nombre = "Ruby"
            },
            new Tecnologia
            {
                Id = 7,
                Nombre = "Swift"
            },
            new Tecnologia
            {
                Id = 8,
                Nombre = "Kotlin"
            },
            new Tecnologia
            {
                Id = 9,
                Nombre = "TypeScript"
            },
            new Tecnologia
            {
                Id = 10,
                Nombre = "C++"
            },
            new Tecnologia
            {
                Id = 11,
                Nombre = "Vue.js"
            },
            new Tecnologia
            {
                Id = 12,
                Nombre = "React"
            },
            new Tecnologia
            {
                Id = 13,
                Nombre = "Angular"
            },
            new Tecnologia
            {
                Id = 14,
                Nombre = "Node.js"
            },
            new Tecnologia
            {
                Id = 15,
                Nombre = "Django"
            },
            new Tecnologia
            {
                Id = 16,
                Nombre = "Flask"
            },
            new Tecnologia
            {
                Id = 17,
                Nombre = "Express.js"
            },
            new Tecnologia
            {
                Id = 18,
                Nombre = "Laravel"
            },
            new Tecnologia
            {
                Id = 19,
                Nombre = "Spring Boot"
            },
            new Tecnologia
            {
                Id = 20,
                Nombre = "Ruby on Rails"
            },
            new Tecnologia
            {
                Id = 21,
                Nombre = ".NET Core"
            },
            new Tecnologia
            {
                Id = 22,
                Nombre = "Go"
            },
            new Tecnologia
            {
                Id = 23,
                Nombre = "Vue.js"
            },
            new Tecnologia
            {
                Id = 24,
                Nombre = "React Native"
            },
            new Tecnologia
            {
                Id = 25,
                Nombre = "Flutter"
            },
            new Tecnologia
            {
                Id = 26,
                Nombre = "jQuery"
            },
            new Tecnologia
            {
                Id = 27,
                Nombre = "Bootstrap"
            },
            new Tecnologia
            {
                Id = 28,
                Nombre = "Sass"
            },
            new Tecnologia
            {
                Id = 29,
                Nombre = "LESS"
            },
            new Tecnologia
            {
                Id = 30,
                Nombre = "Tailwind CSS"
            },
            new Tecnologia
            {
                Id = 31,
                Nombre = "Rust"
            },
            new Tecnologia
            {
                Id = 32,
                Nombre = "Dart"
            },
            new Tecnologia
            {
                Id = 33,
                Nombre = "Elixir"
            },
            new Tecnologia
            {
                Id = 34,
                Nombre = "Haskell"
            },
            new Tecnologia
            {
                Id = 35,
                Nombre = "Scala"
            },
            new Tecnologia
            {
                Id = 36,
                Nombre = "Erlang"
            },
            new Tecnologia
            {
                Id = 37,
                Nombre = "R"
            },
            new Tecnologia
            {
                Id = 38,
                Nombre = "Julia"
            },
            new Tecnologia
            {
                Id = 39,
                Nombre = "Groovy"
            },
            new Tecnologia
            {
                Id = 40,
                Nombre = "Clojure"
            }
        );



    }
}
