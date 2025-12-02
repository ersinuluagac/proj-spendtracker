using Microsoft.EntityFrameworkCore;
using SpendTracker.Repositories.Contexts;
using SpendTracker.Repositories.Interfaces;

namespace SpendTracker.Repositories.Implementations;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<T> FindAll(bool trackChanges)
    {
        return !trackChanges
            ? _context.Set<T>().AsNoTracking()
            : _context.Set<T>();
    }
}
