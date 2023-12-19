namespace Dominio.Interfaces;
    public interface IUnitOfWork{
        
        IUsuario ? Usuarios { get; }
        IRol ? Roles { get; }
        IUsuarioRoles UsuariosRoles { get; }
        ICiudad ? Ciudades { get; }
        IDepartamento ? Departamentos { get; }
        IDisponibilidadViaje ? DisponibilidadViajes { get; }
        IEspecialidad ? Especialidades { get; }
        IGenero ? Generos { get; }
        INivelIngles ? NivelIngles { get; }
        IPais ? Pais { get; }
        IPerfil ? Perfiles { get; }
        IPerfilSolicitud ? PerfilSolicitudes { get; }
        IPerfilTecnologia ? PerfilTecnologias { get; }
        ISeniority ? Senioritys { get; }
        ISolicitud ? Solicitudes { get; }
        ITecnologia ? Tecnologias { get; }
        Task<int> SaveAsync();
        
    }
