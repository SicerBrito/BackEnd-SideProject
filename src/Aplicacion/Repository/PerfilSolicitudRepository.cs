using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class PerfilSolicitudRepository : GenericRepository<PerfilSolicitud>, IPerfilSolicitud
{
    private readonly DbAppContext _Context;
    public PerfilSolicitudRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<PerfilSolicitud>> GetAllAsync()
    {
        return await _Context.Set<PerfilSolicitud>()
            .Include(p => p.Perfiles)
            .Include(p => p.Solicitudes)
            .ToListAsync();
    }
}
