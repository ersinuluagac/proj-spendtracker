using SpendTracker.Entities.Models;

namespace SpendTracker.Services.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges);
}
