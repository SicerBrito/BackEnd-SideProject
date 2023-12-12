using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class PerfilRepository : GenericRepository<Perfil>, IPerfil
{
    private readonly DbAppContext _Context;
    public PerfilRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Perfil>> GetAllAsync()
    {
        return await _Context.Set<Perfil>()
            .Include(p => p.Senioritys)
            .Include(p => p.Especialidades)
            .Include(p => p.Ciudades)
            .Include(p => p.NivelDeIngles)
            .Include(p => p.DisponibilidadViajes)
            .Include(p => p.PerfilTecnologias)
            .Include(p => p.PerfilSolicitudes)
            .ToListAsync();
    }




    //! Consulta #1 - Obtener perfiles por especialidad
    public IQueryable<Perfil> GetPerfilesByEspecialidad(int especialidadId)
    {
        return _Context.Perfiles!
            .Where(p => p.FkEspecialidadId == especialidadId);
    }

    //! Consulta #2 - Obtener perfiles por país
    public IQueryable<Perfil> GetPerfilesByPais(int paisId)
    {
        return _Context.Perfiles!
            .Where(p => p.FkUbicacionId == paisId);
    }

    //! Consulta #3 - Obtener perfiles por departamento
    public IQueryable<Perfil> GetPerfilesByDepartamento(int departamentoId)
    {
        return _Context.Perfiles!
            .Where(p => p.FkUbicacionId == departamentoId);
    }

    //! Consulta #4 - Obtener perfiles por ciudad
    public IQueryable<Perfil> GetPerfilesByCiudad(int ciudadId)
    {
        return _Context.Perfiles!
            .Where(p => p.FkUbicacionId == ciudadId);
    }

    //! Consulta #5 - Obtener perfiles por Nivel de Ingles
    public IQueryable<Perfil> GetPerfilesByNivelIngles(int nivelInglesId)
    {
        return _Context.Perfiles!
            .Where(p => p.FkNivelInglesId == nivelInglesId);
    }

    //! Consulta #6 - Obtener perfiles por Seniority
    public IQueryable<Perfil> GetPerfilesBySeniority(int seniorityId)
    {
        return _Context.Perfiles!
            .Where(p => p.FkSeniorityId == seniorityId);
    }
}
