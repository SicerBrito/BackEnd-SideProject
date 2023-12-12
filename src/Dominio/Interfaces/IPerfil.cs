using Dominio.Entities;
namespace Dominio.Interfaces;

    public interface IPerfil : IGenericRepository<Perfil>
    {
        
        //! Consulta #1 - Obtener perfiles por especialidad
        IQueryable<Perfil> GetPerfilesByEspecialidad(int especialidadId);
        
        //! Consulta #2 - Obtener perfiles por país
        IQueryable<Perfil> GetPerfilesByPais(int paisId);

        //! Consulta #3 - Obtener perfiles por departamento
        IQueryable<Perfil> GetPerfilesByDepartamento(int departamentoId);

        //! Consulta #4 - Obtener perfiles por ciudad
        IQueryable<Perfil> GetPerfilesByCiudad(int ciudadId);

        //! Consulta #5 - Obtener perfiles por Nivel de Ingles
        IQueryable<Perfil> GetPerfilesByNivelIngles(int nivelInglesId);

        //! Consulta #6 - Obtener perfiles por Seniority
        IQueryable<Perfil> GetPerfilesBySeniority(int seniorityId);

    }
