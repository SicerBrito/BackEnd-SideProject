using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class SeniorityRepository : GenericRepository<Seniority>, ISeniority
{
    private readonly DbAppContext _Context;
    public SeniorityRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Seniority>> GetAllAsync()
    {
        return await _Context.Set<Seniority>()
            .Include(p => p.Perfiles)
            .ToListAsync();
    }
}
