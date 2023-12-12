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



        
        public IRol ? Roles => _Rol ??= new RolRepository(_Context!);
        public IUsuario ? Usuarios => _Usuario ??= new UsuarioRepository(_Context!);
        public IUsuarioRoles UsuariosRoles => _UsuariosRoles ??= new UsuariosRolesRepository(_Context!);
        public ICiudad? Ciudades => throw new NotImplementedException();
        public IDepartamento? Departamentos => throw new NotImplementedException();
        public IDisponibilidadViaje? DisponibilidadViajes => throw new NotImplementedException();
        public IEspecialidad? Especialidades => throw new NotImplementedException();
        public INivelIngles? NivelIngles => throw new NotImplementedException();
        public IPais? Pais => throw new NotImplementedException();
        public IPerfil? Perfiles => throw new NotImplementedException();
        public IPerfilSolicitud? PerfilSolicitudes => throw new NotImplementedException();
        public IPerfilTecnologia? PerfilTecnologias => throw new NotImplementedException();
        public ISeniority? Senioritys => throw new NotImplementedException();
        public ISolicitud? Solicitudes => throw new NotImplementedException();
        public ITecnologia? Tecnologias => throw new NotImplementedException();
        
        
        public void Dispose(){
            _Context!.Dispose();
            GC.SuppressFinalize(this); 
        }

        public Task<int> SaveAsync(){
            return _Context!.SaveChangesAsync();
        }
    }
