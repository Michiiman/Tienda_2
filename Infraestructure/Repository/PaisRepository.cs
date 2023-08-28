using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository;

    public class PaisRepository : GenericRepository<Pais>, IPais
    {
        protected readonly TiendaContext _context;
        
        public PaisRepository(TiendaContext context) : base (context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Pais>> GetAllAsync()
        {
            return await _context.Paises
                .Include(p => p.Estados)
                .ToListAsync();
        }

        public override async Task<Pais> GetByIdAsync(int id)
        {
            return await _context.Paises
                .Include(p => p.Estados)
                .FirstOrDefaultAsync(p =>  p.Id == id);
        }
    }