using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
{
    private readonly DbAppContext _Context;
    public DepartamentoRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Departamento>> GetAllAsync()
    {
        return await _Context.Set<Departamento>()
            .Include(p => p.Paises)
            .Include(p => p.Ciudades)
            .ToListAsync();
    }
}
