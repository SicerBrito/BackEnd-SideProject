using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class EspecialidadRepository : GenericRepository<Especialidad>, IEspecialidad
{
    private readonly DbAppContext _Context;
    public EspecialidadRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Especialidad>> GetAllAsync()
    {
        return await _Context.Set<Especialidad>()
            .Include(p => p.Perfiles)
            .ToListAsync();
    }
}
