using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class SolicitudRepository : GenericRepository<Solicitud>, ISolicitud
{
    private readonly DbAppContext _Context;
    public SolicitudRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Solicitud>> GetAllAsync()
    {
        return await _Context.Set<Solicitud>()
            .Include(p => p.PerfilSolicitudes)
            .ToListAsync();
    }
}
