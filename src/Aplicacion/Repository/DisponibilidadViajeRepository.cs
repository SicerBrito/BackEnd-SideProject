using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class DisponibilidadViajeRepository : GenericRepository<DisponibilidadViaje>, IDisponibilidadViaje
{
    private readonly DbAppContext _Context;
    public DisponibilidadViajeRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<DisponibilidadViaje>> GetAllAsync()
    {
        return await _Context.Set<DisponibilidadViaje>()
            .Include(p => p.Perfiles)
            .ToListAsync();
    }
}
