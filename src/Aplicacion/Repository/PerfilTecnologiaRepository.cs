using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class PerfilTecnologiaRepository : GenericRepository<PerfilTecnologia>, IPerfilTecnologia
{
    private readonly DbAppContext _Context;
    public PerfilTecnologiaRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<PerfilTecnologia>> GetAllAsync()
    {
        return await _Context.Set<PerfilTecnologia>()
            .Include(p => p.Perfiles)
            .Include(p => p.Tecnologias)
            .ToListAsync();
    }
}
