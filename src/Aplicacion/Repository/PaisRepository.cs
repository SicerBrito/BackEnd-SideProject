using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly DbAppContext _Context;
    public PaisRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _Context.Set<Pais>()
            .Include(p => p.Departamentos)
            .ToListAsync();
    }
}
