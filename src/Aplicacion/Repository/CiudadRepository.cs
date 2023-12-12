using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class CiudadRepository : GenericRepository<Ciudad>, ICiudad
{
    private readonly DbAppContext _Context;
    public CiudadRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Ciudad>> GetAllAsync()
    {
        return await _Context.Set<Ciudad>()
            .Include(p => p.Departamentos)
            .Include(p => p.Perfiles)
            .ToListAsync();
    }
}
