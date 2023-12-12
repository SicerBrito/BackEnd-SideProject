using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class TecnologiaRepository : GenericRepository<Tecnologia>, ITecnologia
{
    private readonly DbAppContext _Context;
    public TecnologiaRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Tecnologia>> GetAllAsync()
    {
        return await _Context.Set<Tecnologia>()
            .Include(p => p.PerfilTecnologias)
            .ToListAsync();
    }
}
