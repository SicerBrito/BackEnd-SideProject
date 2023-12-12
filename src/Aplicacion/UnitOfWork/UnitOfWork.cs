using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork;
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbAppContext ? _Context;
        public UnitOfWork(DbAppContext context){
            _Context = context;
        }


        private RolRepository ? _Rol;
        private UsuarioRepository ? _Usuario;
        private UsuariosRolesRepository ? _UsuariosRoles;
        private CiudadRepository ? _Ciudad;
        private DepartamentoRepository ? _Departamento;
        private DisponibilidadViajeRepository ? _DisponibilidadViaje;
        private EspecialidadRepository ? _Especialidad;
        private NivelInglesRepository ? _NivelIngles;
        private PaisRepository ? _Pais;
        private PerfilRepository ? _Perfil;
        private PerfilSolicitudRepository ? _PerfilSolicitud;
        private PerfilTecnologiaRepository ? _PerfilTecnologia;
        private SeniorityRepository ? _Seniority;
        private SolicitudRepository ? _Solicitud;
        private TecnologiaRepository ? _Tecnologia;
        


        
        public IRol ? Roles => _Rol ??= new RolRepository(_Context!);
        public IUsuario ? Usuarios => _Usuario ??= new UsuarioRepository(_Context!);
        public IUsuarioRoles UsuariosRoles => _UsuariosRoles ??= new UsuariosRolesRepository(_Context!);
        public ICiudad? Ciudades => _Ciudad ??= new CiudadRepository(_Context!);
        public IDepartamento? Departamentos => _Departamento ??= new DepartamentoRepository(_Context!);
        public IDisponibilidadViaje? DisponibilidadViajes => _DisponibilidadViaje ??= new DisponibilidadViajeRepository(_Context!);
        public IEspecialidad? Especialidades => _Especialidad ??= new EspecialidadRepository(_Context!);
        public INivelIngles? NivelIngles => _NivelIngles ??= new NivelInglesRepository(_Context!);
        public IPais? Pais => _Pais ??= new PaisRepository(_Context!);
        public IPerfil? Perfiles => _Perfil ??= new PerfilRepository(_Context!);
        public IPerfilSolicitud? PerfilSolicitudes => _PerfilSolicitud ??= new PerfilSolicitudRepository(_Context!);
        public IPerfilTecnologia? PerfilTecnologias => _PerfilTecnologia ??= new PerfilTecnologiaRepository(_Context!);
        public ISeniority? Senioritys => _Seniority ??= new SeniorityRepository(_Context!);
        public ISolicitud? Solicitudes => _Solicitud ??= new SolicitudRepository(_Context!);
        public ITecnologia? Tecnologias => _Tecnologia ??= new TecnologiaRepository(_Context!);
        
        
        
        public void Dispose(){
            _Context!.Dispose();
            GC.SuppressFinalize(this); 
        }

        public Task<int> SaveAsync(){
            return _Context!.SaveChangesAsync();
        }
    }
