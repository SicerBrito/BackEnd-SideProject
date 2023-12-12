using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class NivelInglesRepository : GenericRepository<NivelIngles>, INivelIngles
{
    private readonly DbAppContext _Context;
    public NivelInglesRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<NivelIngles>> GetAllAsync()
    {
        return await _Context.Set<NivelIngles>()
            .Include(p => p.Perfiles)
            .ToListAsync();
    }
}
