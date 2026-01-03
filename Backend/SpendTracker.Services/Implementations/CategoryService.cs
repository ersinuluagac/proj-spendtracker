using Microsoft.EntityFrameworkCore;
using SpendTracker.Entities.Models;
using SpendTracker.Repositories.Interfaces;
using SpendTracker.Services.Interfaces;

namespace SpendTracker.Services.Implementations;

public class CategoryService : ICategoryService
{
    private readonly IRepositoryManager _repository;

    public CategoryService(IRepositoryManager repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges)
    {
        return await _repository.Category.FindAll(false).ToListAsync();
    }
}
