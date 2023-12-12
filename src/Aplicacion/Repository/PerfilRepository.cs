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
}
