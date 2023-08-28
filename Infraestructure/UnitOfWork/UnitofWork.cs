using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infraestructure.Repository;

namespace Infraestructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly TiendaContext context;
    private PaisRepository _paises;

    public UnitOfWork(TiendaContext _context)
    {
        context = _context;
    }
    public IPais Paises
    {
        get{
            if(_paises == null){
                _paises = new PaisRepository(context);
            }
            return _paises;
        }
    }
    public void Dispose()
    {
        context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}