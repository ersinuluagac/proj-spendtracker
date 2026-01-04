using Microsoft.EntityFrameworkCore;
using SpendTracker.Repositories.Contexts;
using SpendTracker.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SpendTracker.Repositories.Implementations;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    // Fields (Bağımlılıkların tanımlandığı yer)
    protected readonly AppDbContext _context;

    // Constructor (Bağımlılıkların enjekte edildiği yer)
    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }

    // Methods
    #region Read Methods (Veri okuma, sorgulama işlemleri
    public IQueryable<T> FindAll(bool trackChanges)
    {
        return !trackChanges
            ? _context.Set<T>().AsNoTracking()
            : _context.Set<T>();
    }
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        return !trackChanges
            ? _context.Set<T>().Where(expression).AsNoTracking()
            : _context.Set<T>().Where(expression);
    }
    #endregion

    #region Write Methods (Veri ekleme, güncelleme, silme işlemleri)
    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }
    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    #endregion
}
