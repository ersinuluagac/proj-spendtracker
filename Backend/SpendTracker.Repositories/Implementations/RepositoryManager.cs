using SpendTracker.Repositories.Contexts;
using SpendTracker.Repositories.Interfaces;

namespace SpendTracker.Repositories.Implementations;

public class RepositoryManager : IRepositoryManager
{
    private readonly AppDbContext _context;
    private readonly ICategoryRepository _categoryRepository;

    public RepositoryManager(AppDbContext context, ICategoryRepository categoryRepository)
    {
        _context = context;
        _categoryRepository = categoryRepository;
    }

    public ICategoryRepository Category => _categoryRepository;

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
