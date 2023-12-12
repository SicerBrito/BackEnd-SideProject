using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;
    public class DbAppContext : DbContext{

        public DbAppContext(DbContextOptions<DbAppContext> options) : base (options){

        }

        public DbSet<Usuario> ? Usuarios { get; set; } = null!;
        public DbSet<Rol> ? Roles { get; set; } = null!;
        public DbSet<UsuarioRoles> ? UsuariosRoles { get; set; } = null!;
        public DbSet<RefreshToken> ? RefreshTokens { get; set; } = null!;
        public DbSet<Ciudad> ? Ciudades { get; set; } = null!;
        public DbSet<Departamento> ? Departamentos { get; set; } = null!;
        public DbSet<DisponibilidadViaje> ? DisponibilidadViajes { get; set; } = null!;
        public DbSet<Especialidad> ? Especialidades { get; set; } = null!;
        public DbSet<NivelIngles> ? NivelIngles { get; set; } = null!;
        public DbSet<Pais> ? Pais { get; set; } = null!;
        public DbSet<Perfil> ? Perfiles { get; set; } = null!;
        public DbSet<PerfilSolicitud> ? PerfilSolicitudes { get; set; } = null!;
        public DbSet<PerfilTecnologia> ? PerfilTecnologias { get; set; } = null!;
        public DbSet<Seniority> ? Senioritys { get; set; } = null!;
        public DbSet<Solicitud> ? Solicituds { get; set; } = null!;
        public DbSet<Tecnologia> ? Tecnologias { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
