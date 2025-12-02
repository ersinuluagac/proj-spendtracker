using SpendTracker.Entities.Entities;
using SpendTracker.Repositories.Contexts;
using SpendTracker.Repositories.Interfaces;

namespace SpendTracker.Repositories.Implementations;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}
